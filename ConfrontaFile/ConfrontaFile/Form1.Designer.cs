namespace ConfrontaFile
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
            this.BTNSceltaCartella = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BTNEliminaDuplicati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNSceltaCartella
            // 
            this.BTNSceltaCartella.Location = new System.Drawing.Point(12, 12);
            this.BTNSceltaCartella.Name = "BTNSceltaCartella";
            this.BTNSceltaCartella.Size = new System.Drawing.Size(119, 32);
            this.BTNSceltaCartella.TabIndex = 0;
            this.BTNSceltaCartella.Text = "Scegli cartella";
            this.BTNSceltaCartella.UseVisualStyleBackColor = true;
            this.BTNSceltaCartella.Click += new System.EventHandler(this.BTNConfronta_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // BTNEliminaDuplicati
            // 
            this.BTNEliminaDuplicati.Location = new System.Drawing.Point(321, 12);
            this.BTNEliminaDuplicati.Name = "BTNEliminaDuplicati";
            this.BTNEliminaDuplicati.Size = new System.Drawing.Size(154, 32);
            this.BTNEliminaDuplicati.TabIndex = 2;
            this.BTNEliminaDuplicati.Text = "Elimina duplicati";
            this.BTNEliminaDuplicati.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 87);
            this.Controls.Add(this.BTNEliminaDuplicati);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BTNSceltaCartella);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSceltaCartella;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BTNEliminaDuplicati;
    }
}

