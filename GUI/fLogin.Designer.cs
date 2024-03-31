namespace ManageCafe.GUI
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.boxLogin = new System.Windows.Forms.GroupBox();
            this.rdoBtnQuanLy = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoBtnNhanVien = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boxLogin
            // 
            this.boxLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.boxLogin.Controls.Add(this.rdoBtnQuanLy);
            this.boxLogin.Controls.Add(this.pictureBox2);
            this.boxLogin.Controls.Add(this.btnExit);
            this.boxLogin.Controls.Add(this.rdoBtnNhanVien);
            this.boxLogin.Controls.Add(this.btnSubmit);
            this.boxLogin.Controls.Add(this.txtPassword);
            this.boxLogin.Controls.Add(this.TxtUsername);
            this.boxLogin.Controls.Add(this.lblPassword);
            this.boxLogin.Controls.Add(this.lblUserName);
            this.boxLogin.Location = new System.Drawing.Point(13, 14);
            this.boxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.boxLogin.Size = new System.Drawing.Size(490, 472);
            this.boxLogin.TabIndex = 7;
            this.boxLogin.TabStop = false;
            // 
            // rdoBtnQuanLy
            // 
            this.rdoBtnQuanLy.AutoSize = true;
            this.rdoBtnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdoBtnQuanLy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoBtnQuanLy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoBtnQuanLy.Location = new System.Drawing.Point(61, 301);
            this.rdoBtnQuanLy.Name = "rdoBtnQuanLy";
            this.rdoBtnQuanLy.Size = new System.Drawing.Size(103, 24);
            this.rdoBtnQuanLy.TabIndex = 11;
            this.rdoBtnQuanLy.TabStop = true;
            this.rdoBtnQuanLy.Text = "QUẢN LÝ";
            this.rdoBtnQuanLy.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(185, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(375, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoBtnNhanVien
            // 
            this.rdoBtnNhanVien.AutoSize = true;
            this.rdoBtnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdoBtnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoBtnNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoBtnNhanVien.Location = new System.Drawing.Point(61, 271);
            this.rdoBtnNhanVien.Name = "rdoBtnNhanVien";
            this.rdoBtnNhanVien.Size = new System.Drawing.Size(121, 24);
            this.rdoBtnNhanVien.TabIndex = 10;
            this.rdoBtnNhanVien.TabStop = true;
            this.rdoBtnNhanVien.Text = "NHÂN VIÊN";
            this.rdoBtnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(61, 351);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(380, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 213);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(61, 138);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(380, 22);
            this.TxtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(68, 189);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(68, 114);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 499);
            this.Controls.Add(this.boxLogin);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.boxLogin.ResumeLayout(false);
            this.boxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxLogin;
        private System.Windows.Forms.RadioButton rdoBtnQuanLy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoBtnNhanVien;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}