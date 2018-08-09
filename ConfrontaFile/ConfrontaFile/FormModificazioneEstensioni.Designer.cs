namespace ConfrontaFile
{
    partial class FormModificazioneEstensioni
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
            this.CBExt = new System.Windows.Forms.ComboBox();
            this.TXBExt = new System.Windows.Forms.TextBox();
            this.BTNModifica = new System.Windows.Forms.Button();
            this.BTNElimina = new System.Windows.Forms.Button();
            this.BTNAggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBExt
            // 
            this.CBExt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBExt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBExt.FormattingEnabled = true;
            this.CBExt.Location = new System.Drawing.Point(18, 18);
            this.CBExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBExt.Name = "CBExt";
            this.CBExt.Size = new System.Drawing.Size(101, 28);
            this.CBExt.TabIndex = 0;
            this.CBExt.SelectedIndexChanged += new System.EventHandler(this.CBExt_SelectedIndexChanged);
            // 
            // TXBExt
            // 
            this.TXBExt.Location = new System.Drawing.Point(18, 67);
            this.TXBExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBExt.MaxLength = 5;
            this.TXBExt.Name = "TXBExt";
            this.TXBExt.Size = new System.Drawing.Size(101, 26);
            this.TXBExt.TabIndex = 1;
            this.TXBExt.TextChanged += new System.EventHandler(this.TXBExt_TextChanged);
            // 
            // BTNModifica
            // 
            this.BTNModifica.Location = new System.Drawing.Point(139, 66);
            this.BTNModifica.Name = "BTNModifica";
            this.BTNModifica.Size = new System.Drawing.Size(91, 27);
            this.BTNModifica.TabIndex = 2;
            this.BTNModifica.Text = "Modifica";
            this.BTNModifica.UseVisualStyleBackColor = true;
            this.BTNModifica.Click += new System.EventHandler(this.BTNModifica_Click);
            // 
            // BTNElimina
            // 
            this.BTNElimina.Location = new System.Drawing.Point(139, 19);
            this.BTNElimina.Name = "BTNElimina";
            this.BTNElimina.Size = new System.Drawing.Size(91, 27);
            this.BTNElimina.TabIndex = 3;
            this.BTNElimina.Text = "Elimina";
            this.BTNElimina.UseVisualStyleBackColor = true;
            this.BTNElimina.Click += new System.EventHandler(this.BTNElimina_Click);
            // 
            // BTNAggiungi
            // 
            this.BTNAggiungi.Location = new System.Drawing.Point(236, 67);
            this.BTNAggiungi.Name = "BTNAggiungi";
            this.BTNAggiungi.Size = new System.Drawing.Size(91, 27);
            this.BTNAggiungi.TabIndex = 4;
            this.BTNAggiungi.Text = "Aggiungi";
            this.BTNAggiungi.UseVisualStyleBackColor = true;
            this.BTNAggiungi.Click += new System.EventHandler(this.BTNAggiungi_Click);
            // 
            // FormModificazioneEstensioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 109);
            this.Controls.Add(this.BTNAggiungi);
            this.Controls.Add(this.BTNElimina);
            this.Controls.Add(this.BTNModifica);
            this.Controls.Add(this.TXBExt);
            this.Controls.Add(this.CBExt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormModificazioneEstensioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificazioneEstensioni";
            this.Load += new System.EventHandler(this.FormModificazioneEstensioni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBExt;
        private System.Windows.Forms.TextBox TXBExt;
        private System.Windows.Forms.Button BTNModifica;
        private System.Windows.Forms.Button BTNElimina;
        private System.Windows.Forms.Button BTNAggiungi;
    }
}