using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Dictionary
{
    public partial class GoodsForm : UserControl
    {
        public GoodsForm()
        {
            InitializeComponent();
        }
        public GoodsForm(Control contr)
        {
            Parent = contr;
            InitializeComponent();
        }
    }
}
