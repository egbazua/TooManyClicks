namespace TooManyClicks
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userFormLbl = new System.Windows.Forms.Label();
            this.recordTitleLbl = new System.Windows.Forms.Label();
            this.recordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 29);
            this.textBox1.TabIndex = 0;
            // 
            // userFormLbl
            // 
            this.userFormLbl.AutoSize = true;
            this.userFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFormLbl.ForeColor = System.Drawing.Color.White;
            this.userFormLbl.Location = new System.Drawing.Point(16, 22);
            this.userFormLbl.Name = "userFormLbl";
            this.userFormLbl.Size = new System.Drawing.Size(331, 31);
            this.userFormLbl.TabIndex = 1;
            this.userFormLbl.Text = "WHAT IS YOUR NAME?";
            // 
            // recordTitleLbl
            // 
            this.recordTitleLbl.AutoSize = true;
            this.recordTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordTitleLbl.ForeColor = System.Drawing.Color.White;
            this.recordTitleLbl.Location = new System.Drawing.Point(122, 130);
            this.recordTitleLbl.Name = "recordTitleLbl";
            this.recordTitleLbl.Size = new System.Drawing.Size(77, 24);
            this.recordTitleLbl.TabIndex = 2;
            this.recordTitleLbl.Text = "Record:";
            // 
            // recordLbl
            // 
            this.recordLbl.AutoSize = true;
            this.recordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLbl.ForeColor = System.Drawing.Color.Red;
            this.recordLbl.Location = new System.Drawing.Point(205, 136);
            this.recordLbl.Name = "recordLbl";
            this.recordLbl.Size = new System.Drawing.Size(15, 16);
            this.recordLbl.TabIndex = 3;
            this.recordLbl.Text = "0";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.recordLbl);
            this.Controls.Add(this.recordTitleLbl);
            this.Controls.Add(this.userFormLbl);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userForm";
            this.Text = "Save your record!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userFormLbl;
        private System.Windows.Forms.Label recordTitleLbl;
        private System.Windows.Forms.Label recordLbl;
    }
}