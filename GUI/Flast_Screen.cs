using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafe.GUI
{
    public partial class Flast_Screen : Form
    {
        private Timer timer;       
        public Flast_Screen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //khởi tạo timer
            timer = new Timer();
            timer.Interval = 100; //0.1s
            timer.Tick += Timer_Tick;

        }
        
            
        
        private void Flast_Screen_Load(object sender, EventArgs e)
        {
            fLogin frmLogin = new fLogin();
            
            frmLogin.Show();
            
            
            

        }

        private void Flast_Screen_Shown(object sender, EventArgs e)
        {
            //bắt đầu timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Ẩn Flast Screen layer
            this.Visible = false;

            // Dừng timer
            timer.Stop();
        }

    }
}
