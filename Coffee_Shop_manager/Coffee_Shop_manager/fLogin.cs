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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
            MessageBox.Show("Bạn có muốn thoát", "Thông báo",MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
          
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fTable table = new fTable();
            this.Hide();
            table.ShowDialog();
            this.Show();
        }
    }
}
