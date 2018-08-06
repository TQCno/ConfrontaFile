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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BTNEliminaDuplicati.Enabled = Dati.Coppie.Count > 1;
        }

        private void BTNConfronta_Click(object sender, EventArgs e)
        {
            (new FormSceltaCartella()).ShowDialog();
            /*
            Dati.coppie = Funzioni.ConfrontaCartella(progressBar1);
            BTNEliminaDuplicati.Enabled = Dati.coppie.Count > 1;
            */
        }

    }
}
