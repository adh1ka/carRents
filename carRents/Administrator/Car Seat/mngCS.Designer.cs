namespace carRents.Administrator.Car_Seat
{
    partial class mngCS
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
            this.btnRf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvcs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(642, 656);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(112, 72);
            this.btnRf.TabIndex = 37;
            this.btnRf.Text = "Refresh";
            this.btnRf.UseVisualStyleBackColor = true;
            this.btnRf.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(607, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Manage Carseat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(1104, 35);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 59);
            this.btnX.TabIndex = 34;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(58, 381);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(250, 22);
            this.tbNama.TabIndex = 33;
            this.tbNama.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(196, 539);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 72);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(58, 539);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 72);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 656);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 72);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dgvcs
            // 
            this.dgvcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcs.Location = new System.Drawing.Point(347, 153);
            this.dgvcs.Name = "dgvcs";
            this.dgvcs.RowHeadersWidth = 51;
            this.dgvcs.RowTemplate.Height = 24;
            this.dgvcs.Size = new System.Drawing.Size(839, 458);
            this.dgvcs.TabIndex = 29;
            this.dgvcs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcs_CellContentClick);
            this.dgvcs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcs_CellMouseClick);
            // 
            // mngCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 762);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvcs);
            this.Name = "mngCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mngCS";
            this.Load += new System.EventHandler(this.mngCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvcs;
    }
}