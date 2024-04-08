namespace carRents
{
    partial class loginForm
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
            this.btnKtlg = new System.Windows.Forms.Button();
            this.btnLgn = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.lblcp = new System.Windows.Forms.Label();
            this.tbcp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKtlg
            // 
            this.btnKtlg.BackColor = System.Drawing.SystemColors.Control;
            this.btnKtlg.Location = new System.Drawing.Point(348, 398);
            this.btnKtlg.Name = "btnKtlg";
            this.btnKtlg.Size = new System.Drawing.Size(161, 48);
            this.btnKtlg.TabIndex = 5;
            this.btnKtlg.Text = "Lihat Katalog";
            this.btnKtlg.UseVisualStyleBackColor = false;
            this.btnKtlg.Click += new System.EventHandler(this.btnKtlg_Click);
            // 
            // btnLgn
            // 
            this.btnLgn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLgn.Location = new System.Drawing.Point(348, 333);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(161, 48);
            this.btnLgn.TabIndex = 4;
            this.btnLgn.Text = "Login";
            this.btnLgn.UseVisualStyleBackColor = false;
            this.btnLgn.Click += new System.EventHandler(this.btnLgn_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(332, 221);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(191, 22);
            this.tbPwd.TabIndex = 2;
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(332, 174);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(188, 22);
            this.tbUsn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.Control;
            this.btnX.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnX.Location = new System.Drawing.Point(677, 58);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(73, 48);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(388, 257);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(67, 16);
            this.lblcp.TabIndex = 12;
            this.lblcp.Text = "Password";
            // 
            // tbcp
            // 
            this.tbcp.Location = new System.Drawing.Point(389, 289);
            this.tbcp.Name = "tbcp";
            this.tbcp.Size = new System.Drawing.Size(66, 22);
            this.tbcp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Masukkan Captcha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(302, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "CAR RENT SYSTEM APP";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcp);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKtlg);
            this.Controls.Add(this.btnLgn);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKtlg;
        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.TextBox tbcp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

