namespace GiaoDienBaiTapLonBackUp
{
    partial class DonHang
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
            this.panelTimKiemKH = new System.Windows.Forms.Panel();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.txtTimKiemDH = new System.Windows.Forms.TextBox();
            this.panelTrangThai = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelTimKiemKH.SuspendLayout();
            this.panelTrangThai.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTimKiemKH
            // 
            this.panelTimKiemKH.BackColor = System.Drawing.SystemColors.Control;
            this.panelTimKiemKH.Controls.Add(this.btnBanHang);
            this.panelTimKiemKH.Controls.Add(this.txtTimKiemDH);
            this.panelTimKiemKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiemKH.Location = new System.Drawing.Point(0, 0);
            this.panelTimKiemKH.Name = "panelTimKiemKH";
            this.panelTimKiemKH.Size = new System.Drawing.Size(754, 73);
            this.panelTimKiemKH.TabIndex = 3;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(63)))));
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.Location = new System.Drawing.Point(616, 12);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(132, 44);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // txtTimKiemDH
            // 
            this.txtTimKiemDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemDH.Location = new System.Drawing.Point(37, 12);
            this.txtTimKiemDH.Name = "txtTimKiemDH";
            this.txtTimKiemDH.Size = new System.Drawing.Size(573, 22);
            this.txtTimKiemDH.TabIndex = 0;
            this.txtTimKiemDH.Enter += new System.EventHandler(this.txtTimKiemDH_Enter);
            this.txtTimKiemDH.Leave += new System.EventHandler(this.txtTimKiemDH_Leave);
            // 
            // panelTrangThai
            // 
            this.panelTrangThai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTrangThai.Controls.Add(this.label1);
            this.panelTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrangThai.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTrangThai.Location = new System.Drawing.Point(0, 73);
            this.panelTrangThai.Name = "panelTrangThai";
            this.panelTrangThai.Size = new System.Drawing.Size(754, 54);
            this.panelTrangThai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 57);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng số đơn:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(156, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(136, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 127);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(754, 271);
            this.dgvHoaDon.TabIndex = 6;
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 455);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTrangThai);
            this.Controls.Add(this.panelTimKiemKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonHang";
            this.Text = "DonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DonHang_Load);
            this.panelTimKiemKH.ResumeLayout(false);
            this.panelTimKiemKH.PerformLayout();
            this.panelTrangThai.ResumeLayout(false);
            this.panelTrangThai.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimKiemKH;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.TextBox txtTimKiemDH;
        private System.Windows.Forms.Panel panelTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}