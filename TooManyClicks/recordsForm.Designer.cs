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
            this.recordsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // titleRecordLbl
            // 
            this.titleRecordLbl.AutoSize = true;
            this.titleRecordLbl.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRecordLbl.ForeColor = System.Drawing.Color.Red;
            this.titleRecordLbl.Location = new System.Drawing.Point(163, 26);
            this.titleRecordLbl.Name = "titleRecordLbl";
            this.titleRecordLbl.Size = new System.Drawing.Size(199, 51);
            this.titleRecordLbl.TabIndex = 0;
            this.titleRecordLbl.Text = "RECORDS";
            // 
            // recordsDgv
            // 
            this.recordsDgv.AllowUserToAddRows = false;
            this.recordsDgv.AllowUserToDeleteRows = false;
            this.recordsDgv.AllowUserToResizeRows = false;
            this.recordsDgv.BackgroundColor = System.Drawing.Color.White;
            this.recordsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsDgv.Location = new System.Drawing.Point(38, 104);
            this.recordsDgv.Name = "recordsDgv";
            this.recordsDgv.Size = new System.Drawing.Size(443, 241);
            this.recordsDgv.TabIndex = 1;
            // 
            // recordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(519, 401);
            this.Controls.Add(this.recordsDgv);
            this.Controls.Add(this.titleRecordLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recordsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.recordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleRecordLbl;
        private System.Windows.Forms.DataGridView recordsDgv;
    }
}