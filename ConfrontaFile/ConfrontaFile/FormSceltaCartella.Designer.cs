namespace ConfrontaFile
{
    partial class FormSceltaCartella
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
            this.TXBPercorso = new System.Windows.Forms.TextBox();
            this.BTNScegliCartella = new System.Windows.Forms.Button();
            this.CBImmagini = new System.Windows.Forms.CheckBox();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.CBVideo = new System.Windows.Forms.CheckBox();
            this.BTNImmaginiExt = new System.Windows.Forms.Button();
            this.BTNVideoExt = new System.Windows.Forms.Button();
            this.BTNCerca = new System.Windows.Forms.Button();
            this.BTNAltroExt = new System.Windows.Forms.Button();
            this.CBAltro = new System.Windows.Forms.CheckBox();
            this.LBLFileUguali = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXBPercorso
            // 
            this.TXBPercorso.Location = new System.Drawing.Point(14, 14);
            this.TXBPercorso.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXBPercorso.Name = "TXBPercorso";
            this.TXBPercorso.ReadOnly = true;
            this.TXBPercorso.Size = new System.Drawing.Size(531, 26);
            this.TXBPercorso.TabIndex = 0;
            // 
            // BTNScegliCartella
            // 
            this.BTNScegliCartella.Location = new System.Drawing.Point(553, 14);
            this.BTNScegliCartella.Name = "BTNScegliCartella";
            this.BTNScegliCartella.Size = new System.Drawing.Size(36, 26);
            this.BTNScegliCartella.TabIndex = 1;
            this.BTNScegliCartella.Text = "...";
            this.BTNScegliCartella.UseVisualStyleBackColor = true;
            this.BTNScegliCartella.Click += new System.EventHandler(this.BTNScegliCartella_Click);
            // 
            // CBImmagini
            // 
            this.CBImmagini.AutoSize = true;
            this.CBImmagini.Checked = true;
            this.CBImmagini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBImmagini.Location = new System.Drawing.Point(14, 77);
            this.CBImmagini.Name = "CBImmagini";
            this.CBImmagini.Size = new System.Drawing.Size(92, 24);
            this.CBImmagini.TabIndex = 2;
            this.CBImmagini.Text = "Immagini";
            this.CBImmagini.UseVisualStyleBackColor = true;
            this.CBImmagini.CheckedChanged += new System.EventHandler(this.CBImmagini_CheckedChanged);
            // 
            // PB
            // 
            this.PB.ForeColor = System.Drawing.Color.DarkCyan;
            this.PB.Location = new System.Drawing.Point(14, 48);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(575, 23);
            this.PB.TabIndex = 3;
            // 
            // CBVideo
            // 
            this.CBVideo.AutoSize = true;
            this.CBVideo.Checked = true;
            this.CBVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVideo.Location = new System.Drawing.Point(14, 107);
            this.CBVideo.Name = "CBVideo";
            this.CBVideo.Size = new System.Drawing.Size(69, 24);
            this.CBVideo.TabIndex = 4;
            this.CBVideo.Text = "Video";
            this.CBVideo.UseVisualStyleBackColor = true;
            this.CBVideo.CheckedChanged += new System.EventHandler(this.CBVideo_CheckedChanged);
            // 
            // BTNImmaginiExt
            // 
            this.BTNImmaginiExt.Location = new System.Drawing.Point(112, 78);
            this.BTNImmaginiExt.Name = "BTNImmaginiExt";
            this.BTNImmaginiExt.Size = new System.Drawing.Size(25, 23);
            this.BTNImmaginiExt.TabIndex = 5;
            this.BTNImmaginiExt.UseVisualStyleBackColor = true;
            // 
            // BTNVideoExt
            // 
            this.BTNVideoExt.Location = new System.Drawing.Point(112, 108);
            this.BTNVideoExt.Name = "BTNVideoExt";
            this.BTNVideoExt.Size = new System.Drawing.Size(25, 23);
            this.BTNVideoExt.TabIndex = 6;
            this.BTNVideoExt.UseVisualStyleBackColor = true;
            // 
            // BTNCerca
            // 
            this.BTNCerca.Location = new System.Drawing.Point(519, 132);
            this.BTNCerca.Name = "BTNCerca";
            this.BTNCerca.Size = new System.Drawing.Size(70, 28);
            this.BTNCerca.TabIndex = 7;
            this.BTNCerca.Text = "Cerca";
            this.BTNCerca.UseVisualStyleBackColor = true;
            this.BTNCerca.Click += new System.EventHandler(this.BTNCerca_Click);
            // 
            // BTNAltroExt
            // 
            this.BTNAltroExt.Location = new System.Drawing.Point(112, 137);
            this.BTNAltroExt.Name = "BTNAltroExt";
            this.BTNAltroExt.Size = new System.Drawing.Size(25, 23);
            this.BTNAltroExt.TabIndex = 9;
            this.BTNAltroExt.UseVisualStyleBackColor = true;
            // 
            // CBAltro
            // 
            this.CBAltro.AutoSize = true;
            this.CBAltro.Checked = true;
            this.CBAltro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBAltro.Location = new System.Drawing.Point(14, 137);
            this.CBAltro.Name = "CBAltro";
            this.CBAltro.Size = new System.Drawing.Size(61, 24);
            this.CBAltro.TabIndex = 8;
            this.CBAltro.Text = "Altro";
            this.CBAltro.UseVisualStyleBackColor = true;
            this.CBAltro.CheckedChanged += new System.EventHandler(this.CBAltro_CheckedChanged);
            // 
            // LBLFileUguali
            // 
            this.LBLFileUguali.AutoSize = true;
            this.LBLFileUguali.Enabled = false;
            this.LBLFileUguali.Location = new System.Drawing.Point(442, 107);
            this.LBLFileUguali.Name = "LBLFileUguali";
            this.LBLFileUguali.Size = new System.Drawing.Size(147, 20);
            this.LBLFileUguali.TabIndex = 10;
            this.LBLFileUguali.Text = "999 elementi trovati";
            // 
            // FormSceltaCartella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 176);
            this.Controls.Add(this.LBLFileUguali);
            this.Controls.Add(this.BTNAltroExt);
            this.Controls.Add(this.CBAltro);
            this.Controls.Add(this.BTNCerca);
            this.Controls.Add(this.BTNVideoExt);
            this.Controls.Add(this.BTNImmaginiExt);
            this.Controls.Add(this.CBVideo);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.CBImmagini);
            this.Controls.Add(this.BTNScegliCartella);
            this.Controls.Add(this.TXBPercorso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormSceltaCartella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSceltaCartella";
            this.Load += new System.EventHandler(this.FormSceltaCartella_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBPercorso;
        private System.Windows.Forms.Button BTNScegliCartella;
        private System.Windows.Forms.CheckBox CBImmagini;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.CheckBox CBVideo;
        private System.Windows.Forms.Button BTNImmaginiExt;
        private System.Windows.Forms.Button BTNVideoExt;
        private System.Windows.Forms.Button BTNCerca;
        private System.Windows.Forms.Button BTNAltroExt;
        private System.Windows.Forms.CheckBox CBAltro;
        private System.Windows.Forms.Label LBLFileUguali;
    }
}