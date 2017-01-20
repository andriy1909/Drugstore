using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class MainForm : Form
    {
        public int user = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutorizationForm form = new AutorizationForm();
            form.ShowDialog();
            user = form.getUserId();
            if(user!=-1)
            {
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
            }
            else
            {
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm form = new AutorizationForm();
            form.ShowDialog();
            user = form.getUserId();
            if (user != -1)
            {
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
            }
            else
            {
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = -1;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GoodsForm form = new GoodsForm() { Dock = DockStyle.Fill, Parent = pnContext };
            
        }
    }
}
