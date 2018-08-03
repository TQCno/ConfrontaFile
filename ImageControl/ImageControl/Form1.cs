﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void BTNSelezionaCartella_Click(object sender, EventArgs e)
        {
            Data.extensions.Clear();
            var ok = Funzioni.GetExtensions(CBPNG, CBJPG, CBBMP);
            if (!ok) { MessageBox.Show("Errore, selezionare almeno un'estenzione", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            Funzioni.SelectFolder(CBNames, false);
            Funzioni.AddNames(CBNames);
        }

        private void BTNAggiungiCartella_Click(object sender, EventArgs e)
        {
            Data.extensions.Clear();
            var ok = Funzioni.GetExtensions(CBPNG, CBJPG, CBBMP);
            if (!ok) { MessageBox.Show("Errore, selezionare almeno un'estenzione", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            Funzioni.SelectFolder(CBNames, true);
            Funzioni.AddNames(CBNames);
        }
    }
}
