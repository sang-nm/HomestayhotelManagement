namespace HomestayhotelManagement.Views
{
    partial class ChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbPasswordOld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbReNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveNewPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐỔI MẬT KHẨU";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSaveNewPass);
            this.groupBox2.Controls.Add(this.txbReNewPassword);
            this.groupBox2.Controls.Add(this.txbNewPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbPasswordOld);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(212, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 337);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mật khẩu mới";
            // 
            // txbPasswordOld
            // 
            this.txbPasswordOld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPasswordOld.Location = new System.Drawing.Point(353, 102);
            this.txbPasswordOld.Name = "txbPasswordOld";
            this.txbPasswordOld.PasswordChar = '#';
            this.txbPasswordOld.Size = new System.Drawing.Size(253, 26);
            this.txbPasswordOld.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mật khẩu hiện tại";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNewPassword.Location = new System.Drawing.Point(353, 134);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.PasswordChar = '#';
            this.txbNewPassword.Size = new System.Drawing.Size(253, 26);
            this.txbNewPassword.TabIndex = 16;
            // 
            // txbReNewPassword
            // 
            this.txbReNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbReNewPassword.Location = new System.Drawing.Point(353, 166);
            this.txbReNewPassword.Name = "txbReNewPassword";
            this.txbReNewPassword.PasswordChar = '#';
            this.txbReNewPassword.Size = new System.Drawing.Size(253, 26);
            this.txbReNewPassword.TabIndex = 17;
            // 
            // btnSaveNewPass
            // 
            this.btnSaveNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveNewPass.Location = new System.Drawing.Point(459, 198);
            this.btnSaveNewPass.Name = "btnSaveNewPass";
            this.btnSaveNewPass.Size = new System.Drawing.Size(147, 37);
            this.btnSaveNewPass.TabIndex = 27;
            this.btnSaveNewPass.Text = "Đồng ý";
            this.btnSaveNewPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1264, 620);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNewPass;
        private System.Windows.Forms.TextBox txbReNewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPasswordOld;
    }
}
