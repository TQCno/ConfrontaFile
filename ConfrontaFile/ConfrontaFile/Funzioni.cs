using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Drawing;

namespace ConfrontaFile
{
    class Funzioni
    {
        private static bool UguaglianzaFile(string percorsoFile1, string percorsoFile2)
        {
            var c1 = new FileInfo(percorsoFile1).Length == new FileInfo(percorsoFile2).Length;
            if (!c1) { return false; }
            return File.ReadAllBytes(percorsoFile1).SequenceEqual(File.ReadAllBytes(percorsoFile2));
        }



        public static bool ScegliCartella(ref string @base)
        {
            using (var folderBD = new FolderBrowserDialog())
            {
                DialogResult result = folderBD.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBD.SelectedPath)) { @base = folderBD.SelectedPath; return true; }
                else { return false; }
            }
        }

        public static List<string> CercaFileValidi(string percorsoCartella)
        {
            var percorsiFiles = Directory.GetFiles(percorsoCartella).ToList();
            int i = 0;

            while (i < percorsiFiles.Count)
            {
                bool immaigni = Dati.Immagini && Dati.ImmaginiExt.Count > 0;
                bool video = Dati.Video && Dati.VideoExt.Count > 0;
                bool altro = Dati.Altro && Dati.AltroExt.Count > 0;

                var appo = percorsiFiles[i];

                if (immaigni) { immaigni = Contiene(Dati.ImmaginiExt, percorsiFiles[i]); }
                if (video) { video = Contiene(Dati.VideoExt, percorsiFiles[i]); }
                if (altro) { video = Contiene(Dati.AltroExt, percorsiFiles[i]); }

                if (!immaigni && !video && !altro) { percorsiFiles.RemoveAt(i); }
                else { i++; }
            }

            return percorsiFiles;
        }

        private static bool Contiene(List<string> estensioni, string percorso)
        {
            var estensione2 = Path.GetExtension(percorso);
            foreach (var estensione in estensioni)
            {
                var estensione1 = '.' + estensione;
                if (estensione1 == estensione2 || estensione1.ToUpper() == estensione2 || estensione1.ToLower() == estensione2) { return true; }
            }
            return false;
        }

        public static List<Duplicato> CercaFileDuplicati(ProgressBar pb)
        {
            var duplicati = new List<Duplicato>();
            pb.Visible = true;
            pb.Maximum = Dati.PercorsiFile.Count * Dati.PercorsiFile.Count;

            for (int i = 0; i < Dati.PercorsiFile.Count - 1; i++)
            {
                pb.Value = Dati.PercorsiFile.Count * i;
                if (Duplicato.CercaInCopie(duplicati, Dati.PercorsiFile[i])) { continue; }
                for (int j = i + 1; j < Dati.PercorsiFile.Count; j++)
                {
                    pb.Value = Dati.PercorsiFile.Count * i + j;
                    if (!StessoTipoDiEstensione(Dati.PercorsiFile[i], Dati.PercorsiFile[j])) { continue; }
                    if (Duplicato.CercaInCopie(duplicati, Dati.PercorsiFile[j])) { continue; }
                    if (UguaglianzaFile(Dati.PercorsiFile[i], Dati.PercorsiFile[j]))
                    {
                        int k = 0;
                        if (Duplicato.CercaInPrincipale(duplicati, Dati.PercorsiFile[i], out k)) { duplicati[k].Copie.Add(Dati.PercorsiFile[j]); }
                        else { duplicati.Add(new Duplicato(Dati.PercorsiFile[i], new List<string>() { Dati.PercorsiFile[j] })); }
                    }
                }
            }

            pb.Visible = false;
            return duplicati;
        }

        private static bool StessoTipoDiEstensione(string percorsoFile1, string percorsoFile2)
        {
            if (Contiene(Dati.ImmaginiExt, percorsoFile1) && Contiene(Dati.ImmaginiExt, percorsoFile2)) { return true; }
            if (Contiene(Dati.VideoExt, percorsoFile1) && Contiene(Dati.VideoExt, percorsoFile2)) { return true; }
            if (Contiene(Dati.AltroExt, percorsoFile1) && Contiene(Dati.AltroExt, percorsoFile2)) { return true; }
            return false;
        }

        public static bool ControlloEstensione(string estensione)
        {
            return Regex.IsMatch(estensione, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$");
        }

        public static void AggiornaComboBox(ComboBox cb, List<string> list, int index)
        {
            cb.Text = "";
            cb.Items.Clear();
            if (list.Count == 0) { return; }
            if (index < 0) { index = 0; }
            if (index >= list.Count) { index = list.Count - 1; }
            cb.Items.AddRange(list.ToArray());
            cb.SelectedIndex = index;
        }

        public static bool CercaInLista(List<string> estensioni, string estensione)
        {
            foreach (var ext in estensioni) { if (estensione == ext) { return true; } }
            return false;
        }

        public static void ImpostaPictureBox(PictureBox pBFile1, PictureBox pBFile2, Label lBLNomeFile1, Label lBLNomeFile2, Label lBLNumero)
        {
            if (Contiene(Dati.ImmaginiExt, Dati.Coppie[0].Principale))
                pBFile1.Image = PrendiImmagineDaPercorso(Dati.Coppie[0].Principale);
            else
                pBFile1.Image = null;

            if (Contiene(Dati.ImmaginiExt, Dati.Coppie[0].Copie[0]))
                pBFile2.Image = PrendiImmagineDaPercorso(Dati.Coppie[0].Principale);
            else
                pBFile2.Image = null;

            lBLNomeFile1.Text = Path.GetFileName(Dati.Coppie[0].Principale);
            lBLNomeFile2.Text = Path.GetFileName(Dati.Coppie[0].Copie[0]);

            var appo = lBLNumero.Text.Split(' ');

            lBLNumero.Text = (int.Parse(appo[0]) + 1) + " / " + appo[2];
        }

        private static Image PrendiImmagineDaPercorso(string percorso)
        {
            var buffer = File.ReadAllBytes(percorso);
            using (var ms = new MemoryStream(buffer, 0, buffer.Length)) { return Image.FromStream(ms, true); }
        }

        public static bool ImpostaCoppie(List<Duplicato> coppie, Label lBLNumero)
        {
            while (coppie[0].Copie.Count == 0)
            {
                coppie.RemoveAt(0);
                lBLNumero.Text = "1 / " + coppie[0].Copie.Count;
            }
            if (coppie.Count < 1) { return false; }
            return true;
        }
    }
}
