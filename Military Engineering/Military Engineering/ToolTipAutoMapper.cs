using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Engineering
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
    }
}
