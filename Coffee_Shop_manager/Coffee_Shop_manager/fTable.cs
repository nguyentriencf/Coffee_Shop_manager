using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_manager
{
    public partial class fTable : Form
    {
        public fTable()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAcountProfile profile = new fAcountProfile();
            profile.ShowDialog();
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmind admind = new fAdmind();
            admind.ShowDialog();
        }
    }
}
