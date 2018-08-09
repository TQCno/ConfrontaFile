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
    public partial class FormModificazioneEstensioni : Form
    {
        public FormModificazioneEstensioni()
        {
            InitializeComponent();
        }

        private void FormModificazioneEstensioni_Load(object sender, EventArgs e)
        {
            Funzioni.AggiornaComboBox(CBExt, Dati.ModificaExt, 0);
            BTNElimina.Enabled = Dati.ModificaExt.Count > 0;
        }

        private void CBExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXBExt.Text = CBExt.Items[CBExt.SelectedIndex].ToString();
            BTNModifica.Enabled = false;
        }

        private void TXBExt_TextChanged(object sender, EventArgs e)
        {
            if (Funzioni.ControlloEstensione(TXBExt.Text))
            {
                BTNModifica.Enabled = true;
                BTNAggiungi.Enabled = !Funzioni.CercaInLista(Dati.ModificaExt, TXBExt.Text);
            }
            else
            {
                BTNModifica.Enabled = false;
                BTNAggiungi.Enabled = false;
            }
        }

        private void BTNModifica_Click(object sender, EventArgs e)
        {
            int i = CBExt.SelectedIndex;
            Dati.ModificaExt[i] = TXBExt.Text;
            Funzioni.AggiornaComboBox(CBExt, Dati.ModificaExt, i);
        }

        private void BTNElimina_Click(object sender, EventArgs e)
        {
            var estensione = CBExt.Items[CBExt.SelectedIndex].ToString();
            int i = CBExt.SelectedIndex;
            Dati.ModificaExt.RemoveAt(i);
            Funzioni.AggiornaComboBox(CBExt, Dati.ModificaExt, i);
            if (Dati.ModificaExt.Count == 0) { BTNElimina.Enabled = false; }
            if(TXBExt.Text == estensione) { BTNAggiungi.Enabled = true; }
        }

        private void BTNAggiungi_Click(object sender, EventArgs e)
        {
            int i = CBExt.SelectedIndex;
            Dati.ModificaExt.Add(TXBExt.Text);
            Funzioni.AggiornaComboBox(CBExt, Dati.ModificaExt, Dati.ModificaExt.Count - 1);
            if (Dati.ModificaExt.Count > 0) { BTNElimina.Enabled = true; }
            BTNAggiungi.Enabled = !Funzioni.CercaInLista(Dati.ModificaExt, TXBExt.Text);
        }
    }
}
