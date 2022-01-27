namespace TooManyClicks
{
    partial class TooManyClicks_Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TooManyClicks_Form));
            this.título_Lbl = new System.Windows.Forms.Label();
            this.iniciar_Btn = new System.Windows.Forms.Button();
            this.imagen_Pbx = new System.Windows.Forms.PictureBox();
            this.jugar_Btn = new System.Windows.Forms.Button();
            this.clicks_Lbl = new System.Windows.Forms.Label();
            this.cantidadclicks_Btn = new System.Windows.Forms.Label();
            this.contador_Lbl = new System.Windows.Forms.Label();
            this.numerocontador_Lbl = new System.Windows.Forms.Label();
            this.temporizador_Tmr = new System.Windows.Forms.Timer(this.components);
            this.tiempo_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // título_Lbl
            // 
            this.título_Lbl.AutoSize = true;
            this.título_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.título_Lbl.ForeColor = System.Drawing.Color.White;
            this.título_Lbl.Location = new System.Drawing.Point(15, 8);
            this.título_Lbl.Name = "título_Lbl";
            this.título_Lbl.Size = new System.Drawing.Size(408, 74);
            this.título_Lbl.TabIndex = 0;
            this.título_Lbl.Text = "TooManyClicks";
            // 
            // iniciar_Btn
            // 
            this.iniciar_Btn.BackColor = System.Drawing.Color.Red;
            this.iniciar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_Btn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_Btn.ForeColor = System.Drawing.Color.White;
            this.iniciar_Btn.Location = new System.Drawing.Point(28, 113);
            this.iniciar_Btn.Name = "iniciar_Btn";
            this.iniciar_Btn.Size = new System.Drawing.Size(170, 74);
            this.iniciar_Btn.TabIndex = 1;
            this.iniciar_Btn.Text = "INICIAR";
            this.iniciar_Btn.UseVisualStyleBackColor = false;
            this.iniciar_Btn.Click += new System.EventHandler(this.Iniciar_Btn_Click);
            // 
            // imagen_Pbx
            // 
            this.imagen_Pbx.BackColor = System.Drawing.Color.Transparent;
            this.imagen_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("imagen_Pbx.Image")));
            this.imagen_Pbx.Location = new System.Drawing.Point(68, 190);
            this.imagen_Pbx.Name = "imagen_Pbx";
            this.imagen_Pbx.Size = new System.Drawing.Size(87, 69);
            this.imagen_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_Pbx.TabIndex = 4;
            this.imagen_Pbx.TabStop = false;
            // 
            // jugar_Btn
            // 
            this.jugar_Btn.BackColor = System.Drawing.Color.Red;
            this.jugar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jugar_Btn.Enabled = false;
            this.jugar_Btn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar_Btn.ForeColor = System.Drawing.Color.White;
            this.jugar_Btn.Location = new System.Drawing.Point(232, 113);
            this.jugar_Btn.Name = "jugar_Btn";
            this.jugar_Btn.Size = new System.Drawing.Size(170, 74);
            this.jugar_Btn.TabIndex = 5;
            this.jugar_Btn.Text = "¡CLICK!";
            this.jugar_Btn.UseVisualStyleBackColor = false;
            this.jugar_Btn.Click += new System.EventHandler(this.Jugar_Btn_Click);
            // 
            // clicks_Lbl
            // 
            this.clicks_Lbl.AutoSize = true;
            this.clicks_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicks_Lbl.Location = new System.Drawing.Point(354, 204);
            this.clicks_Lbl.Name = "clicks_Lbl";
            this.clicks_Lbl.Size = new System.Drawing.Size(33, 38);
            this.clicks_Lbl.TabIndex = 2;
            this.clicks_Lbl.Text = "0";
            // 
            // cantidadclicks_Btn
            // 
            this.cantidadclicks_Btn.AutoSize = true;
            this.cantidadclicks_Btn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadclicks_Btn.Location = new System.Drawing.Point(225, 204);
            this.cantidadclicks_Btn.Name = "cantidadclicks_Btn";
            this.cantidadclicks_Btn.Size = new System.Drawing.Size(123, 38);
            this.cantidadclicks_Btn.TabIndex = 6;
            this.cantidadclicks_Btn.Text = "CLICKS:";
            // 
            // contador_Lbl
            // 
            this.contador_Lbl.AutoSize = true;
            this.contador_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_Lbl.Location = new System.Drawing.Point(21, 280);
            this.contador_Lbl.Name = "contador_Lbl";
            this.contador_Lbl.Size = new System.Drawing.Size(190, 38);
            this.contador_Lbl.TabIndex = 7;
            this.contador_Lbl.Text = "CONTADOR: ";
            // 
            // numerocontador_Lbl
            // 
            this.numerocontador_Lbl.AutoSize = true;
            this.numerocontador_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerocontador_Lbl.Location = new System.Drawing.Point(210, 280);
            this.numerocontador_Lbl.Name = "numerocontador_Lbl";
            this.numerocontador_Lbl.Size = new System.Drawing.Size(49, 38);
            this.numerocontador_Lbl.TabIndex = 8;
            this.numerocontador_Lbl.Text = "30";
            // 
            // temporizador_Tmr
            // 
            this.temporizador_Tmr.Interval = 1000;
            this.temporizador_Tmr.Tick += new System.EventHandler(this.Temporizador_Tmr_Tick);
            // 
            // tiempo_Lbl
            // 
            this.tiempo_Lbl.AutoSize = true;
            this.tiempo_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_Lbl.Location = new System.Drawing.Point(259, 280);
            this.tiempo_Lbl.Name = "tiempo_Lbl";
            this.tiempo_Lbl.Size = new System.Drawing.Size(173, 38);
            this.tiempo_Lbl.TabIndex = 9;
            this.tiempo_Lbl.Text = "SEGUNDOS";
            // 
            // TooManyClicks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(438, 343);
            this.Controls.Add(this.tiempo_Lbl);
            this.Controls.Add(this.numerocontador_Lbl);
            this.Controls.Add(this.contador_Lbl);
            this.Controls.Add(this.cantidadclicks_Btn);
            this.Controls.Add(this.jugar_Btn);
            this.Controls.Add(this.imagen_Pbx);
            this.Controls.Add(this.clicks_Lbl);
            this.Controls.Add(this.iniciar_Btn);
            this.Controls.Add(this.título_Lbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TooManyClicks_Form";
            this.Text = "TooManyClicks";
            ((System.ComponentModel.ISupportInitialize)(this.imagen_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label título_Lbl;
        private System.Windows.Forms.Button iniciar_Btn;
        private System.Windows.Forms.PictureBox imagen_Pbx;
        private System.Windows.Forms.Button jugar_Btn;
        private System.Windows.Forms.Label clicks_Lbl;
        private System.Windows.Forms.Label cantidadclicks_Btn;
        private System.Windows.Forms.Label contador_Lbl;
        private System.Windows.Forms.Label numerocontador_Lbl;
        private System.Windows.Forms.Timer temporizador_Tmr;
        private System.Windows.Forms.Label tiempo_Lbl;
    }
}

