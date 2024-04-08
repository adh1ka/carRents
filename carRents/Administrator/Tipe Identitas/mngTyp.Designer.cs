namespace carRents.Administrator.Tipe_Identitas
{
    partial class mngTyp
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvti = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvti)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(16, 391);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(250, 22);
            this.tbNama.TabIndex = 11;
            this.tbNama.Visible = false;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(154, 549);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 72);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 549);
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
            this.btnAdd.Location = new System.Drawing.Point(305, 666);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 72);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvti
            // 
            this.dgvti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvti.Location = new System.Drawing.Point(305, 163);
            this.dgvti.Name = "dgvti";
            this.dgvti.RowHeadersWidth = 51;
            this.dgvti.RowTemplate.Height = 24;
            this.dgvti.Size = new System.Drawing.Size(839, 458);
            this.dgvti.TabIndex = 7;
            this.dgvti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvti_CellContentClick);
            this.dgvti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvti_CellMouseClick);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(1062, 45);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 59);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Manage Identity Type";
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(600, 666);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(112, 72);
            this.btnRf.TabIndex = 28;
            this.btnRf.Text = "Refresh";
            this.btnRf.UseVisualStyleBackColor = true;
            this.btnRf.Click += new System.EventHandler(this.btnRf_Click);
            // 
            // mngTyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 793);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvti);
            this.Name = "mngTyp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mngTyp";
            this.Load += new System.EventHandler(this.mngTyp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvti;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRf;
    }
}