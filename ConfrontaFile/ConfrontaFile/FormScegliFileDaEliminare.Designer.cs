namespace ConfrontaFile
{
    partial class FormScegliFileDaEliminare
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
            this.PBFile1 = new System.Windows.Forms.PictureBox();
            this.LBLNumero = new System.Windows.Forms.Label();
            this.LBLNomeFile1 = new System.Windows.Forms.Label();
            this.LBLNomeFile2 = new System.Windows.Forms.Label();
            this.PBFile2 = new System.Windows.Forms.PictureBox();
            this.BTNEliminaFile1 = new System.Windows.Forms.Button();
            this.BTNEliminaFile2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFile2)).BeginInit();
            this.SuspendLayout();
            // 
            // PBFile1
            // 
            this.PBFile1.Location = new System.Drawing.Point(13, 58);
            this.PBFile1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBFile1.Name = "PBFile1";
            this.PBFile1.Size = new System.Drawing.Size(225, 174);
            this.PBFile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFile1.TabIndex = 0;
            this.PBFile1.TabStop = false;
            // 
            // LBLNumero
            // 
            this.LBLNumero.AutoSize = true;
            this.LBLNumero.Location = new System.Drawing.Point(13, 9);
            this.LBLNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNumero.Name = "LBLNumero";
            this.LBLNumero.Size = new System.Drawing.Size(39, 20);
            this.LBLNumero.TabIndex = 1;
            this.LBLNumero.Text = "0 / 0";
            // 
            // LBLNomeFile1
            // 
            this.LBLNomeFile1.AutoSize = true;
            this.LBLNomeFile1.Location = new System.Drawing.Point(13, 237);
            this.LBLNomeFile1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNomeFile1.Name = "LBLNomeFile1";
            this.LBLNomeFile1.Size = new System.Drawing.Size(114, 20);
            this.LBLNomeFile1.TabIndex = 2;
            this.LBLNomeFile1.Text = "LBLNomeFile1";
            // 
            // LBLNomeFile2
            // 
            this.LBLNomeFile2.AutoSize = true;
            this.LBLNomeFile2.Location = new System.Drawing.Point(340, 237);
            this.LBLNomeFile2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNomeFile2.Name = "LBLNomeFile2";
            this.LBLNomeFile2.Size = new System.Drawing.Size(114, 20);
            this.LBLNomeFile2.TabIndex = 3;
            this.LBLNomeFile2.Text = "LBLNomeFile2";
            // 
            // PBFile2
            // 
            this.PBFile2.Location = new System.Drawing.Point(344, 58);
            this.PBFile2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBFile2.Name = "PBFile2";
            this.PBFile2.Size = new System.Drawing.Size(225, 174);
            this.PBFile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFile2.TabIndex = 4;
            this.PBFile2.TabStop = false;
            // 
            // BTNEliminaFile1
            // 
            this.BTNEliminaFile1.Location = new System.Drawing.Point(13, 290);
            this.BTNEliminaFile1.Name = "BTNEliminaFile1";
            this.BTNEliminaFile1.Size = new System.Drawing.Size(225, 29);
            this.BTNEliminaFile1.TabIndex = 5;
            this.BTNEliminaFile1.Text = "Elimina file 1";
            this.BTNEliminaFile1.UseVisualStyleBackColor = true;
            this.BTNEliminaFile1.Click += new System.EventHandler(this.BTNEliminaFile1_Click);
            // 
            // BTNEliminaFile2
            // 
            this.BTNEliminaFile2.Location = new System.Drawing.Point(344, 290);
            this.BTNEliminaFile2.Name = "BTNEliminaFile2";
            this.BTNEliminaFile2.Size = new System.Drawing.Size(225, 29);
            this.BTNEliminaFile2.TabIndex = 6;
            this.BTNEliminaFile2.Text = "Elimina file 2";
            this.BTNEliminaFile2.UseVisualStyleBackColor = true;
            this.BTNEliminaFile2.Click += new System.EventHandler(this.BTNEliminaFile2_Click);
            // 
            // FormScegliFileDaEliminare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 346);
            this.Controls.Add(this.BTNEliminaFile2);
            this.Controls.Add(this.BTNEliminaFile1);
            this.Controls.Add(this.PBFile2);
            this.Controls.Add(this.LBLNomeFile2);
            this.Controls.Add(this.LBLNomeFile1);
            this.Controls.Add(this.LBLNumero);
            this.Controls.Add(this.PBFile1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormScegliFileDaEliminare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScegliFileDaEliminare";
            this.Load += new System.EventHandler(this.FormScegliFileDaEliminare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFile2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBFile1;
        private System.Windows.Forms.Label LBLNumero;
        private System.Windows.Forms.Label LBLNomeFile1;
        private System.Windows.Forms.Label LBLNomeFile2;
        private System.Windows.Forms.PictureBox PBFile2;
        private System.Windows.Forms.Button BTNEliminaFile1;
        private System.Windows.Forms.Button BTNEliminaFile2;
    }
}