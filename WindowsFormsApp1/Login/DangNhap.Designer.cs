namespace WindowsFormsApp1
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tkhoan = new System.Windows.Forms.TextBox();
            this.Mkhau = new System.Windows.Forms.TextBox();
            this.Hien = new System.Windows.Forms.CheckBox();
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(805, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(450, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đăng Nhập";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tkhoan
            // 
            this.Tkhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tkhoan.Location = new System.Drawing.Point(601, 214);
            this.Tkhoan.Margin = new System.Windows.Forms.Padding(4);
            this.Tkhoan.Name = "Tkhoan";
            this.Tkhoan.Size = new System.Drawing.Size(235, 36);
            this.Tkhoan.TabIndex = 2;
            this.Tkhoan.TextChanged += new System.EventHandler(this.Tkhoan_TextChanged);
            // 
            // Mkhau
            // 
            this.Mkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mkhau.Location = new System.Drawing.Point(601, 269);
            this.Mkhau.Margin = new System.Windows.Forms.Padding(4);
            this.Mkhau.Name = "Mkhau";
            this.Mkhau.Size = new System.Drawing.Size(235, 36);
            this.Mkhau.TabIndex = 3;
            this.Mkhau.UseSystemPasswordChar = true;
            this.Mkhau.UseWaitCursor = true;
            // 
            // Hien
            // 
            this.Hien.AutoSize = true;
            this.Hien.BackColor = System.Drawing.Color.Transparent;
            this.Hien.Location = new System.Drawing.Point(465, 324);
            this.Hien.Margin = new System.Windows.Forms.Padding(4);
            this.Hien.Name = "Hien";
            this.Hien.Size = new System.Drawing.Size(115, 20);
            this.Hien.TabIndex = 4;
            this.Hien.Text = "Hiện Mật Khẩu";
            this.Hien.UseVisualStyleBackColor = false;
            this.Hien.CheckedChanged += new System.EventHandler(this.Hien_CheckedChanged);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(460, 200);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.MaximumSize = new System.Drawing.Size(133, 123);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(133, 50);
            this.User.TabIndex = 5;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1333, 1231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 72);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(624, 379);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 71);
            this.button3.TabIndex = 8;
            this.button3.Text = "Đăng Ký";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Hien);
            this.Controls.Add(this.Mkhau);
            this.Controls.Add(this.Tkhoan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siêu Thị Mini";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Tkhoan;
        private System.Windows.Forms.TextBox Mkhau;
        private System.Windows.Forms.CheckBox Hien;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

