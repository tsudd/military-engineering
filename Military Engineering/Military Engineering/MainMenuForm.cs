using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationsCore;

namespace Military_Engineering
{
    public partial class MainMenuForm : Form
    {
        const string mainInfo = "МЕТОДИКИ ИНЖЕНЕРНЫХ РАСЧЕТОВ";
        const string fortificationInfo = "МЕТОДИКА РАСЧЕТА ФОРТИФИКАЦИОННОГО \nОБОРУДОВАНИЯ ПОЗИЦИЙ И РАЙОНОВ \nРАСПОЛОЖЕНИЯ ВОЙСК";
        const string fencingInfo = "МЕТОДИКА РАСЧЕТА СИСТЕМЫ ИНЖЕНЕРНЫХ ЗАГРАЖДЕНИЙ";
        string buffer;
        bool coolFlag;
        public MainMenuForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            buffer = "";
            coolFlag = false;
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
            byte[] bytes = Convert.FromBase64String(AESDecrypt(Properties.Resources.p1str, key));
            MemoryStream s = new MemoryStream(bytes);
            Bitmap b1 = new Bitmap(s);

            bytes = Convert.FromBase64String(AESDecrypt(Properties.Resources.p2str, key));
            s = new MemoryStream(bytes);
            Bitmap b2 = new Bitmap(s);
            
            bytes = Convert.FromBase64String(AESDecrypt(Properties.Resources.p3str, key));
            string s3 = Encoding.UTF8.GetString(bytes);

            coolFlag = true;

            Task.Factory.StartNew(() =>
            {
                InfoLabel.Invoke((MethodInvoker)(() =>
                {
                    InfoLabel.Text = s3;
                }));

                ColorMatrix cm = new ColorMatrix();
                cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = cm.Matrix44 = 1;
                cm.Matrix33 = 1;
                ImageAttributes imageAttributes = new ImageAttributes();
                for(float i = 1f; i > 0; i -= 0.01f)
                {
                    Bitmap b3 = new Bitmap(b1);
                    Graphics g = Graphics.FromImage(b3);

                    cm.Matrix33 = i;
                    imageAttributes.SetColorMatrix(cm);

                    g.DrawImage(b2, new Rectangle(0, 0, b3.Width, b3.Height), 0, 0, b2.Width, b2.Height, GraphicsUnit.Pixel, imageAttributes);
                    PreviewPictureBox.Invoke((MethodInvoker)(() =>
                    {
                        PreviewPictureBox.Image = b3;
                    }));
                    Thread.Sleep(50);
                }

                coolFlag = false;
                buffer = "";
            });
        }

        string AESEncrypt(string input, string key)
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

        string AESDecrypt(string input, string key)
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
    }
}
