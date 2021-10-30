using ColorThemeManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering
{
    class ToolTipAutoMapper
    {
        Control control { get; set; }
        ToolTip toolTip { get; set; }
        Dictionary<string, string> info { get; set; }
        public ToolTipAutoMapper(Control control, ToolTip toolTip, Dictionary<string, string> info)
        {
            this.control = control;
            this.toolTip = toolTip;
            this.info = info;
        }
        
        public void Map()
        {
            Type controlType = control.GetType();
            FieldInfo[] members = controlType.GetFields();
            foreach(MemberInfo member in members)
            {
                if(info.ContainsKey(member.Name))
                {
                    toolTip.SetToolTip((Control)controlType.GetField(member.Name).GetValue(control), info[member.Name]);                 
                }
            }
        }

        public void Configure( ColorTheme colorTheme)
        {
            toolTip.BackColor = colorTheme.SecondarySecondaryColor;
            toolTip.ForeColor = colorTheme.MainForeColor;

            toolTip.OwnerDraw = true;
            toolTip.Draw += (sender, e) =>
            {
                Font f = new Font("Arial", 9f);
                e.DrawBackground();
                e.DrawBorder();
                e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(1, 2));
            };
        }
    }
}
