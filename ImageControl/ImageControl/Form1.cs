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
        }

        private void PBPixel_Click(object sender, EventArgs e)
        {
            Funzioni.ScegliImmagine(PBPixel, LBPixel);
        }




    }
}
