namespace carRents.Administrator
{
    partial class mngUser
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
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvUsr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(32, 369);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(248, 22);
            this.tbPwd.TabIndex = 13;
            this.tbPwd.Visible = false;
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(32, 312);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(248, 22);
            this.tbUsn.TabIndex = 12;
            this.tbUsn.Visible = false;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(32, 247);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(248, 22);
            this.tbNama.TabIndex = 11;
            this.tbNama.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(472, 619);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 72);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "CheckID";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(32, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 72);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(311, 619);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 72);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvUsr
            // 
            this.dgvUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsr.Location = new System.Drawing.Point(311, 136);
            this.dgvUsr.Name = "dgvUsr";
            this.dgvUsr.RowHeadersWidth = 51;
            this.dgvUsr.RowTemplate.Height = 24;
            this.dgvUsr.Size = new System.Drawing.Size(839, 458);
            this.dgvUsr.TabIndex = 7;
            this.dgvUsr.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsr_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(168, 498);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 72);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(1068, 34);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 59);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 72);
            this.button1.TabIndex = 26;
            this.button1.Text = "CheckRole";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mngUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 745);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsr);
            this.Name = "mngUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mngUser";
            this.Load += new System.EventHandler(this.mngUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button button1;
    }
}