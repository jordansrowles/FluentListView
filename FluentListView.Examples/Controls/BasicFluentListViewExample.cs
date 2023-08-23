using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentListView.Examples.Controls
{
    public partial class BasicFluentListViewExample : Fluent.FluentListView
    {
        public BasicFluentListViewExample() 
        {
            Size = new Size(200, 200);
            ShowColumns = true;
            Theme = OLVTheme.XP;
            ItemFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "c_BasicFluentListViewExample";

            Properties.Columns = new() { "col1", "col2" };
            Properties.ColumnNames = new() { "Col 1", "Col 2" };

            Items = new List<Person>();
        }
    }
}
