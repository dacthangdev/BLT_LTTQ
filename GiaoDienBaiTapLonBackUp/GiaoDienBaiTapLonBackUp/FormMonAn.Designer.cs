namespace GiaoDienBaiTapLonBackUp
{
    partial class FormMonAn
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
            this.iconbtnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnGoiMon = new FontAwesome.Sharp.IconButton();
            this.iconbtnShip = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddGoiMon = new System.Windows.Forms.Button();
            this.txtGoiMon = new System.Windows.Forms.TextBox();
            this.btnMinusGoiMon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconbtnClose
            // 
            this.iconbtnClose.FlatAppearance.BorderSize = 0;
            this.iconbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnClose.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconbtnClose.IconColor = System.Drawing.Color.Black;
            this.iconbtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnClose.IconSize = 20;
            this.iconbtnClose.Location = new System.Drawing.Point(17, 12);
            this.iconbtnClose.Name = "iconbtnClose";
            this.iconbtnClose.Size = new System.Drawing.Size(33, 26);
            this.iconbtnClose.TabIndex = 3;
            this.iconbtnClose.UseVisualStyleBackColor = true;
            this.iconbtnClose.Click += new System.EventHandler(this.iconbtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddGoiMon);
            this.panel1.Controls.Add(this.txtGoiMon);
            this.panel1.Controls.Add(this.btnMinusGoiMon);
            this.panel1.Controls.Add(this.iconbtnGoiMon);
            this.panel1.Controls.Add(this.iconbtnClose);
            this.panel1.Controls.Add(this.iconbtnShip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(547, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 499);
            this.panel1.TabIndex = 4;
            // 
            // iconbtnGoiMon
            // 
            this.iconbtnGoiMon.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
            this.iconbtnGoiMon.IconColor = System.Drawing.Color.Black;
            this.iconbtnGoiMon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnGoiMon.IconSize = 32;
            this.iconbtnGoiMon.Location = new System.Drawing.Point(53, 204);
            this.iconbtnGoiMon.Name = "iconbtnGoiMon";
            this.iconbtnGoiMon.Size = new System.Drawing.Size(106, 54);
            this.iconbtnGoiMon.TabIndex = 13;
            this.iconbtnGoiMon.Text = "Gọi món";
            this.iconbtnGoiMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnGoiMon.UseVisualStyleBackColor = true;
            // 
            // iconbtnShip
            // 
            this.iconbtnShip.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.iconbtnShip.IconColor = System.Drawing.Color.Black;
            this.iconbtnShip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnShip.IconSize = 32;
            this.iconbtnShip.Location = new System.Drawing.Point(53, 126);
            this.iconbtnShip.Name = "iconbtnShip";
            this.iconbtnShip.Size = new System.Drawing.Size(106, 54);
            this.iconbtnShip.TabIndex = 12;
            this.iconbtnShip.Text = "Mang về";
            this.iconbtnShip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnShip.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 499);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 340);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddGoiMon
            // 
            this.btnAddGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoiMon.Location = new System.Drawing.Point(53, 289);
            this.btnAddGoiMon.Name = "btnAddGoiMon";
            this.btnAddGoiMon.Size = new System.Drawing.Size(23, 23);
            this.btnAddGoiMon.TabIndex = 18;
            this.btnAddGoiMon.Text = "+";
            this.btnAddGoiMon.UseVisualStyleBackColor = true;
            // 
            // txtGoiMon
            // 
            this.txtGoiMon.Location = new System.Drawing.Point(82, 289);
            this.txtGoiMon.Name = "txtGoiMon";
            this.txtGoiMon.Size = new System.Drawing.Size(48, 22);
            this.txtGoiMon.TabIndex = 20;
            // 
            // btnMinusGoiMon
            // 
            this.btnMinusGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusGoiMon.Location = new System.Drawing.Point(136, 288);
            this.btnMinusGoiMon.Name = "btnMinusGoiMon";
            this.btnMinusGoiMon.Size = new System.Drawing.Size(23, 23);
            this.btnMinusGoiMon.TabIndex = 19;
            this.btnMinusGoiMon.Text = "-";
            this.btnMinusGoiMon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số lượng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 160);
            this.panel4.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giá tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giới thiệu món ăn:";
            // 
            // FormMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonAn";
            this.Text = "FormMonAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconbtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddGoiMon;
        private System.Windows.Forms.TextBox txtGoiMon;
        private System.Windows.Forms.Button btnMinusGoiMon;
        private FontAwesome.Sharp.IconButton iconbtnGoiMon;
        private FontAwesome.Sharp.IconButton iconbtnShip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}