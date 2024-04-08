namespace carRents.Administrator.User
{
    partial class addUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbLvl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nama";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(578, 130);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 59);
            this.btnX.TabIndex = 19;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 59);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.Location = new System.Drawing.Point(273, 519);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(82, 59);
            this.btnCncl.TabIndex = 17;
            this.btnCncl.Text = "cncel";
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(273, 394);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(181, 22);
            this.tbPwd.TabIndex = 14;
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(273, 333);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(181, 22);
            this.tbUsn.TabIndex = 13;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(273, 272);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(181, 22);
            this.tbNama.TabIndex = 12;
            // 
            // cbLvl
            // 
            this.cbLvl.FormattingEnabled = true;
            this.cbLvl.Items.AddRange(new object[] {
            "Administrator",
            "Karyawan"});
            this.cbLvl.Location = new System.Drawing.Point(273, 460);
            this.cbLvl.Name = "cbLvl";
            this.cbLvl.Size = new System.Drawing.Size(188, 24);
            this.cbLvl.TabIndex = 24;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.cbLvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.Controls.Add(this.tbNama);
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addUser";
            this.Load += new System.EventHandler(this.addUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbLvl;
    }
}