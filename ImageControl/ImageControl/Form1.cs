using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PBPalette_Click(object sender, EventArgs e)
        {
            Funzioni.ScegliImmagine(PBPalette, LBPalette);
            BTNVerifica.BackColor = Color.Gray;
        }

        private void PBPixel_Click(object sender, EventArgs e)
        {
            Funzioni.ScegliImmagine(PBPixel, LBPixel);
            BTNVerifica.BackColor = Color.Gray;
        }

        private void BTNVerifica_Click(object sender, EventArgs e)
        {
            Funzioni.Verifica(BTNVerifica, PBPalette);
        }
    }
}
