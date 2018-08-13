using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConfrontaFile
{
    public partial class FormScegliFileDaEliminare : Form
    {
        public FormScegliFileDaEliminare()
        {
            InitializeComponent();
        }

        private void FormScegliFileDaEliminare_Load(object sender, EventArgs e)
        {
            LBLNumero.Text = "0 / " + Dati.Coppie[0].Copie.Count;
            Funzioni.ImpostaPictureBox(PBFile1, PBFile2, LBLNomeFile1, LBLNomeFile2, LBLNumero);
        }

        private void BTNEliminaFile1_Click(object sender, EventArgs e)
        {
            File.Delete(Dati.Coppie[0].Principale);
            Dati.Coppie[0].Principale = Dati.Coppie[0].Copie[0];
            Dati.Coppie[0].Copie.RemoveAt(0);
            if (Funzioni.ImpostaCoppie(Dati.Coppie, LBLNumero))
                Funzioni.ImpostaPictureBox(PBFile1, PBFile2, LBLNomeFile1, LBLNomeFile2, LBLNumero);
            else { Close(); }
        }

        private void BTNEliminaFile2_Click(object sender, EventArgs e)
        {
            File.Delete(Dati.Coppie[0].Copie[0]);
            Dati.Coppie[0].Copie.RemoveAt(0);
            if (Funzioni.ImpostaCoppie(Dati.Coppie, LBLNumero))
                Funzioni.ImpostaPictureBox(PBFile1, PBFile2, LBLNomeFile1, LBLNomeFile2, LBLNumero);
            else { Close(); }
        }
    }
}
