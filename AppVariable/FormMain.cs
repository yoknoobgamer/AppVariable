using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVariable
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.MdiParent = this;
            formRegister.Dock = DockStyle.Fill;
            formRegister.Show();
        }
    }
}
