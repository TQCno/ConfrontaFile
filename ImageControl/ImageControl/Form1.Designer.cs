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
            this.BTNSelezionaCartella = new System.Windows.Forms.Button();
            this.CBNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPNG = new System.Windows.Forms.CheckBox();
            this.BTNAggiungiCartella = new System.Windows.Forms.Button();
            this.CBBMP = new System.Windows.Forms.CheckBox();
            this.CBJPG = new System.Windows.Forms.CheckBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.BTNCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSelezionaCartella
            // 
            this.BTNSelezionaCartella.Location = new System.Drawing.Point(12, 12);
            this.BTNSelezionaCartella.Name = "BTNSelezionaCartella";
            this.BTNSelezionaCartella.Size = new System.Drawing.Size(147, 34);
            this.BTNSelezionaCartella.TabIndex = 0;
            this.BTNSelezionaCartella.Text = "Seleziona cartella";
            this.BTNSelezionaCartella.UseVisualStyleBackColor = true;
            this.BTNSelezionaCartella.Click += new System.EventHandler(this.BTNSelezionaCartella_Click);
            // 
            // CBNames
            // 
            this.CBNames.FormattingEnabled = true;
            this.CBNames.Location = new System.Drawing.Point(64, 62);
            this.CBNames.Name = "CBNames";
            this.CBNames.Size = new System.Drawing.Size(366, 28);
            this.CBNames.Sorted = true;
            this.CBNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files:";
            // 
            // CBPNG
            // 
            this.CBPNG.AutoSize = true;
            this.CBPNG.Checked = true;
            this.CBPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBPNG.Location = new System.Drawing.Point(339, 18);
            this.CBPNG.Name = "CBPNG";
            this.CBPNG.Size = new System.Drawing.Size(62, 24);
            this.CBPNG.TabIndex = 4;
            this.CBPNG.Text = "PNG";
            this.CBPNG.UseVisualStyleBackColor = true;
            // 
            // BTNAggiungiCartella
            // 
            this.BTNAggiungiCartella.Location = new System.Drawing.Point(165, 12);
            this.BTNAggiungiCartella.Name = "BTNAggiungiCartella";
            this.BTNAggiungiCartella.Size = new System.Drawing.Size(147, 34);
            this.BTNAggiungiCartella.TabIndex = 5;
            this.BTNAggiungiCartella.Text = "AggiungiCartella";
            this.BTNAggiungiCartella.UseVisualStyleBackColor = true;
            this.BTNAggiungiCartella.Click += new System.EventHandler(this.BTNAggiungiCartella_Click);
            // 
            // CBBMP
            // 
            this.CBBMP.AutoSize = true;
            this.CBBMP.Location = new System.Drawing.Point(407, 18);
            this.CBBMP.Name = "CBBMP";
            this.CBBMP.Size = new System.Drawing.Size(62, 24);
            this.CBBMP.TabIndex = 6;
            this.CBBMP.Text = "BMP";
            this.CBBMP.UseVisualStyleBackColor = true;
            // 
            // CBJPG
            // 
            this.CBJPG.AutoSize = true;
            this.CBJPG.Location = new System.Drawing.Point(475, 18);
            this.CBJPG.Name = "CBJPG";
            this.CBJPG.Size = new System.Drawing.Size(59, 24);
            this.CBJPG.TabIndex = 7;
            this.CBJPG.Text = "JPG";
            this.CBJPG.UseVisualStyleBackColor = true;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PB1.Location = new System.Drawing.Point(32, 120);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(250, 250);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB1.TabIndex = 8;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PB2.Location = new System.Drawing.Point(620, 120);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(250, 250);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB2.TabIndex = 9;
            this.PB2.TabStop = false;
            // 
            // BTNCompare
            // 
            this.BTNCompare.Location = new System.Drawing.Point(829, 396);
            this.BTNCompare.Name = "BTNCompare";
            this.BTNCompare.Size = new System.Drawing.Size(115, 52);
            this.BTNCompare.TabIndex = 10;
            this.BTNCompare.Text = "Compara";
            this.BTNCompare.UseVisualStyleBackColor = true;
            this.BTNCompare.Click += new System.EventHandler(this.BTNCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 460);
            this.Controls.Add(this.BTNCompare);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.CBJPG);
            this.Controls.Add(this.CBBMP);
            this.Controls.Add(this.BTNAggiungiCartella);
            this.Controls.Add(this.CBPNG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBNames);
            this.Controls.Add(this.BTNSelezionaCartella);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSelezionaCartella;
        private System.Windows.Forms.ComboBox CBNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBPNG;
        private System.Windows.Forms.Button BTNAggiungiCartella;
        private System.Windows.Forms.CheckBox CBBMP;
        private System.Windows.Forms.CheckBox CBJPG;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.Button BTNCompare;
    }
}

