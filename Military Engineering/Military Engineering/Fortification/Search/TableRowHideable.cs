using MilitaryEngineering.Fortification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification.Search
{
    internal class TableRowHideable : IHideable
    {
        public RowStyle Style { get; set; }
        public IVisible Panel { get; }

        public TableRowHideable(RowStyle style, IVisible panel)
        {
            Style = style;
            Panel = panel;
        }

        public void Hide()
        {
            Style.SizeType = SizeType.Absolute;
            Style.Height = 0;
            Panel.Visible = false;
        }

        public void Show()
        {
            Style.SizeType = SizeType.AutoSize;
            Panel.Visible = true;
        }
    }
}

//internal class TableRowHideable : IHideable
//{
//    private TableLayoutStyleCollection collection;
//    private int index;
//    public TableRowHideable(TableLayoutStyleCollection collection, int index)
//    {
//        this.collection = collection;
//        this.index = index;
//    }

//    public void Hide()
//    {
//        collection[index].SizeType = SizeType.Absolute;
//    }

//    public void Show()
//    {
//        collection[index].SizeType = SizeType.AutoSize;
//    }
//}