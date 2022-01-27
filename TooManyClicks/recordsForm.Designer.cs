namespace TooManyClicks
{
    partial class recordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recordsForm));
            this.titleRecordLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleRecordLbl
            // 
            this.titleRecordLbl.AutoSize = true;
            this.titleRecordLbl.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRecordLbl.ForeColor = System.Drawing.Color.White;
            this.titleRecordLbl.Location = new System.Drawing.Point(163, 26);
            this.titleRecordLbl.Name = "titleRecordLbl";
            this.titleRecordLbl.Size = new System.Drawing.Size(199, 51);
            this.titleRecordLbl.TabIndex = 0;
            this.titleRecordLbl.Text = "RECORDS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecord,
            this.nameUser,
            this.score,
            this.dateRecord});
            this.dataGridView1.Location = new System.Drawing.Point(38, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // idRecord
            // 
            this.idRecord.HeaderText = "ID";
            this.idRecord.Name = "idRecord";
            // 
            // nameUser
            // 
            this.nameUser.HeaderText = "Nombre de usuario";
            this.nameUser.Name = "nameUser";
            // 
            // score
            // 
            this.score.HeaderText = "Puntuación";
            this.score.Name = "score";
            // 
            // dateRecord
            // 
            this.dateRecord.HeaderText = "Fecha";
            this.dateRecord.Name = "dateRecord";
            // 
            // recordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(519, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleRecordLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recordsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleRecordLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecord;
    }
}