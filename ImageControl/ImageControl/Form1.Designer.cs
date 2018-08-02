namespace ImageControl
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNVerifica = new System.Windows.Forms.Button();
            this.PBPalette = new System.Windows.Forms.PictureBox();
            this.PBPixel = new System.Windows.Forms.PictureBox();
            this.LBPalette = new System.Windows.Forms.Label();
            this.LBPixel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNVerifica
            // 
            this.BTNVerifica.Location = new System.Drawing.Point(397, 264);
            this.BTNVerifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNVerifica.Name = "BTNVerifica";
            this.BTNVerifica.Size = new System.Drawing.Size(112, 35);
            this.BTNVerifica.TabIndex = 0;
            this.BTNVerifica.Text = "Verifica";
            this.BTNVerifica.UseVisualStyleBackColor = true;
            this.BTNVerifica.Click += new System.EventHandler(this.BTNVerifica_Click);
            // 
            // PBPalette
            // 
            this.PBPalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PBPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBPalette.Location = new System.Drawing.Point(12, 12);
            this.PBPalette.Name = "PBPalette";
            this.PBPalette.Size = new System.Drawing.Size(190, 185);
            this.PBPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPalette.TabIndex = 1;
            this.PBPalette.TabStop = false;
            this.PBPalette.Click += new System.EventHandler(this.PBPalette_Click);
            // 
            // PBPixel
            // 
            this.PBPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PBPixel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBPixel.Location = new System.Drawing.Point(320, 12);
            this.PBPixel.Name = "PBPixel";
            this.PBPixel.Size = new System.Drawing.Size(190, 185);
            this.PBPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPixel.TabIndex = 2;
            this.PBPixel.TabStop = false;
            this.PBPixel.Click += new System.EventHandler(this.PBPixel_Click);
            // 
            // LBPalette
            // 
            this.LBPalette.AutoSize = true;
            this.LBPalette.Location = new System.Drawing.Point(12, 200);
            this.LBPalette.Name = "LBPalette";
            this.LBPalette.Size = new System.Drawing.Size(0, 20);
            this.LBPalette.TabIndex = 3;
            // 
            // LBPixel
            // 
            this.LBPixel.AutoSize = true;
            this.LBPixel.Location = new System.Drawing.Point(316, 200);
            this.LBPixel.Name = "LBPixel";
            this.LBPixel.Size = new System.Drawing.Size(0, 20);
            this.LBPixel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 313);
            this.Controls.Add(this.LBPixel);
            this.Controls.Add(this.LBPalette);
            this.Controls.Add(this.PBPixel);
            this.Controls.Add(this.PBPalette);
            this.Controls.Add(this.BTNVerifica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVerifica;
        private System.Windows.Forms.PictureBox PBPalette;
        private System.Windows.Forms.PictureBox PBPixel;
        private System.Windows.Forms.Label LBPalette;
        private System.Windows.Forms.Label LBPixel;
    }
}

