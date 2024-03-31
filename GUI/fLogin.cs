using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafe.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fMainEmployee frmMenu = new fMainEmployee();
            
            frmMenu.Show();
      
           this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ? ","Thông báo ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
