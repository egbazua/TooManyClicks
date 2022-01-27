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
            this.nameUserTbx = new System.Windows.Forms.TextBox();
            this.userFormLbl = new System.Windows.Forms.Label();
            this.recordTitleLbl = new System.Windows.Forms.Label();
            this.recordLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameUserTbx
            // 
            this.nameUserTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUserTbx.Location = new System.Drawing.Point(97, 81);
            this.nameUserTbx.Name = "nameUserTbx";
            this.nameUserTbx.Size = new System.Drawing.Size(176, 29);
            this.nameUserTbx.TabIndex = 0;
            // 
            // userFormLbl
            // 
            this.userFormLbl.AutoSize = true;
            this.userFormLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFormLbl.ForeColor = System.Drawing.Color.White;
            this.userFormLbl.Location = new System.Drawing.Point(16, 22);
            this.userFormLbl.Name = "userFormLbl";
            this.userFormLbl.Size = new System.Drawing.Size(349, 38);
            this.userFormLbl.TabIndex = 1;
            this.userFormLbl.Text = "WHAT IS YOUR NAME?";
            // 
            // recordTitleLbl
            // 
            this.recordTitleLbl.AutoSize = true;
            this.recordTitleLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordTitleLbl.ForeColor = System.Drawing.Color.White;
            this.recordTitleLbl.Location = new System.Drawing.Point(122, 130);
            this.recordTitleLbl.Name = "recordTitleLbl";
            this.recordTitleLbl.Size = new System.Drawing.Size(80, 26);
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
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Red;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(137, 168);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(83, 40);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 220);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.recordLbl);
            this.Controls.Add(this.recordTitleLbl);
            this.Controls.Add(this.userFormLbl);
            this.Controls.Add(this.nameUserTbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save your record!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameUserTbx;
        private System.Windows.Forms.Label userFormLbl;
        private System.Windows.Forms.Label recordTitleLbl;
        private System.Windows.Forms.Label recordLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}