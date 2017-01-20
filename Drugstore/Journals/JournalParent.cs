using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Journals
{
    public partial class JournalParent : UserControl
    {
        public JournalParent()
        {
            InitializeComponent();
        }

        public JournalParent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
