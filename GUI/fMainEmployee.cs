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
    public partial class fMainEmployee : Form
    {
        bool isItemSelected = false;

        public fMainEmployee()
        {
            InitializeComponent();
            

        }

        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }
           

        private void statisticalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tô đậm item khi click chuột vào
            ((ToolStripMenuItem)sender).BackColor = Color.Linen;

            // Set flag
            isItemSelected = true;
            
            Form frm = kiemtratontai(typeof(Form1));
            if (frm != null)
                frm.Activate();
            else
            {
                Form1 fr = new Form1();
                fr.MdiParent = this;
                
                fr.Show();
                fr.BringToFront();
            }
            
        }

        private void homeToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).BackColor = Color.Linen;
        }

        private void homeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Nếu flag là false
            if (!isItemSelected)
            {
                // Trả về màu bình thường cho item
                ((ToolStripMenuItem)sender).BackColor = Color.Transparent;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)

        {
            
            // Tô đậm item khi click chuột vào
            ((ToolStripMenuItem)sender).BackColor = Color.Linen;

            // Set flag
            isItemSelected = true;
            Form frm = kiemtratontai(typeof(fAd));
            if (frm != null)
                frm.Activate();
            else

            {
                fAd fr = new fAd();
                fr.MdiParent = this;
               

                fr.Show();
                
            }
            
        }

       

        private void statisticalReportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Nếu flag là false
            if (!isItemSelected)
            {
                // Trả về màu bình thường cho item
                ((ToolStripMenuItem)sender).BackColor = Color.Transparent;
            }
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMainEmployee_Load(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fAd));
            if (frm != null)
                frm.Activate();
            else
            {
                fAd fr = new fAd();
                fr.MdiParent = this;
                fr.Show();
               


            }
        }
    }
}
