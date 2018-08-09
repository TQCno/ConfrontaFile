using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfrontaFile
{
    public partial class FormSceltaCartella : Form
    {
        public FormSceltaCartella()
        {
            InitializeComponent();
        }

        private void FormSceltaCartella_Load(object sender, EventArgs e)
        {
            TXBPercorso.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dati.PercorsiFile = Funzioni.CercaFileValidi(TXBPercorso.Text);
            LBLFileUguali.Text = Dati.PercorsiFile.Count + " elementi trovati";
            PB.Visible = false;
        }

        private void BTNScegliCartella_Click(object sender, EventArgs e)
        {
            var appo = TXBPercorso.Text;
            Funzioni.ScegliCartella(ref appo);
            TXBPercorso.Text = appo;

            Dati.PercorsiFile = Funzioni.CercaFileValidi(TXBPercorso.Text);
            LBLFileUguali.Text = Dati.PercorsiFile.Count + " elementi trovati";
        }

        private void BTNCerca_Click(object sender, EventArgs e)
        {
            Dati.Coppie = Funzioni.CercaFileDuplicati(PB);
        }

        private void CBImmagini_CheckedChanged(object sender, EventArgs e)
        {
            Dati.Immagini = CBImmagini.Checked;
        }
        private void CBVideo_CheckedChanged(object sender, EventArgs e)
        {
            Dati.Video = CBVideo.Checked;
        }
        private void CBAltro_CheckedChanged(object sender, EventArgs e)
        {
            Dati.Altro = CBAltro.Checked;
        }

        private void BTNImmaginiExt_Click(object sender, EventArgs e)
        {
            Dati.ModificaExt = Dati.ImmaginiExt;
            new FormModificazioneEstensioni().ShowDialog();
        }

        private void BTNVideoExt_Click(object sender, EventArgs e)
        {
            Dati.ModificaExt = Dati.VideoExt;
            new FormModificazioneEstensioni().ShowDialog();
        }

        private void BTNAltroExt_Click(object sender, EventArgs e)
        {
            Dati.ModificaExt = Dati.AltroExt;
            new FormModificazioneEstensioni().ShowDialog();
        }
    }
}
