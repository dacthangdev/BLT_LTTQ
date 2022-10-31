namespace GiaoDienBaiTapLonBackUp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconbtnBanAn = new FontAwesome.Sharp.IconButton();
            this.iconbtnMenu = new FontAwesome.Sharp.IconButton();
            this.panelMediaMenu = new System.Windows.Forms.Panel();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.iconbtnQuanLy = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.iconbtnHome = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelMediaMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.panelSideMenu.Controls.Add(this.iconbtnBanAn);
            this.panelSideMenu.Controls.Add(this.iconbtnMenu);
            this.panelSideMenu.Controls.Add(this.panelMediaMenu);
            this.panelSideMenu.Controls.Add(this.iconbtnQuanLy);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 617);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconbtnBanAn
            // 
            this.iconbtnBanAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnBanAn.FlatAppearance.BorderSize = 0;
            this.iconbtnBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnBanAn.ForeColor = System.Drawing.Color.LightGray;
            this.iconbtnBanAn.IconChar = FontAwesome.Sharp.IconChar.Chair;
            this.iconbtnBanAn.IconColor = System.Drawing.Color.LightGray;
            this.iconbtnBanAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnBanAn.Location = new System.Drawing.Point(0, 322);
            this.iconbtnBanAn.Name = "iconbtnBanAn";
            this.iconbtnBanAn.Size = new System.Drawing.Size(200, 50);
            this.iconbtnBanAn.TabIndex = 6;
            this.iconbtnBanAn.Text = "Bàn ăn";
            this.iconbtnBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnBanAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnBanAn.UseVisualStyleBackColor = true;
            this.iconbtnBanAn.Click += new System.EventHandler(this.iconbtnBanAn_Click);
            // 
            // iconbtnMenu
            // 
            this.iconbtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.iconbtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnMenu.FlatAppearance.BorderSize = 0;
            this.iconbtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnMenu.ForeColor = System.Drawing.Color.LightGray;
            this.iconbtnMenu.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.iconbtnMenu.IconColor = System.Drawing.Color.LightGray;
            this.iconbtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMenu.IconSize = 32;
            this.iconbtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnMenu.Location = new System.Drawing.Point(0, 272);
            this.iconbtnMenu.Name = "iconbtnMenu";
            this.iconbtnMenu.Size = new System.Drawing.Size(200, 50);
            this.iconbtnMenu.TabIndex = 4;
            this.iconbtnMenu.Text = "Menu";
            this.iconbtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnMenu.UseVisualStyleBackColor = false;
            this.iconbtnMenu.Click += new System.EventHandler(this.iconbtnMenu_Click);
            // 
            // panelMediaMenu
            // 
            this.panelMediaMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMediaMenu.Controls.Add(this.btnDonHang);
            this.panelMediaMenu.Controls.Add(this.btnKhachHang);
            this.panelMediaMenu.Controls.Add(this.btnNhanVien);
            this.panelMediaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaMenu.Location = new System.Drawing.Point(0, 150);
            this.panelMediaMenu.Name = "panelMediaMenu";
            this.panelMediaMenu.Size = new System.Drawing.Size(200, 122);
            this.panelMediaMenu.TabIndex = 3;
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.Color.White;
            this.btnDonHang.Location = new System.Drawing.Point(0, 80);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDonHang.Size = new System.Drawing.Size(200, 40);
            this.btnDonHang.TabIndex = 2;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.PeachPuff;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 40);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(200, 40);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(200, 40);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // iconbtnQuanLy
            // 
            this.iconbtnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.iconbtnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnQuanLy.FlatAppearance.BorderSize = 0;
            this.iconbtnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnQuanLy.ForeColor = System.Drawing.Color.LightGray;
            this.iconbtnQuanLy.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconbtnQuanLy.IconColor = System.Drawing.Color.LightGray;
            this.iconbtnQuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnQuanLy.IconSize = 32;
            this.iconbtnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnQuanLy.Location = new System.Drawing.Point(0, 100);
            this.iconbtnQuanLy.Name = "iconbtnQuanLy";
            this.iconbtnQuanLy.Size = new System.Drawing.Size(200, 50);
            this.iconbtnQuanLy.TabIndex = 1;
            this.iconbtnQuanLy.Text = "Quản lý";
            this.iconbtnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnQuanLy.UseVisualStyleBackColor = false;
            this.iconbtnQuanLy.Click += new System.EventHandler(this.iconbtnQuanLy_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.panelPlayer.Controls.Add(this.iconbtnHome);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayer.Location = new System.Drawing.Point(200, 0);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(958, 71);
            this.panelPlayer.TabIndex = 1;
            // 
            // iconbtnHome
            // 
            this.iconbtnHome.FlatAppearance.BorderSize = 0;
            this.iconbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconbtnHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.iconbtnHome.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconbtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnHome.IconSize = 20;
            this.iconbtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnHome.Location = new System.Drawing.Point(42, 12);
            this.iconbtnHome.Name = "iconbtnHome";
            this.iconbtnHome.Size = new System.Drawing.Size(88, 41);
            this.iconbtnHome.TabIndex = 0;
            this.iconbtnHome.Text = "Home\r\n";
            this.iconbtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnHome.UseVisualStyleBackColor = true;
            this.iconbtnHome.Click += new System.EventHandler(this.iconbtnHome_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 71);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(958, 546);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(958, 546);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 617);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMediaMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton iconbtnQuanLy;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelMediaMenu;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private FontAwesome.Sharp.IconButton iconbtnMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconbtnBanAn;
        private FontAwesome.Sharp.IconButton iconbtnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

