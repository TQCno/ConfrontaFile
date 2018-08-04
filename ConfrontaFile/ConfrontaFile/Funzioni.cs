using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConfrontaFile
{
    class Funzioni
    {
        private static bool FilesAreEqual(string file1, string file2)
        {
            return new FileInfo(file1).Length == new FileInfo(file2).Length &&
         File.ReadAllBytes(file1).SequenceEqual(File.ReadAllBytes(file2));
        }

        private static string ScegliCartella()
        {
            var percorso = "";

            using (var folderBD = new FolderBrowserDialog())
            {
                DialogResult result = folderBD.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBD.SelectedPath))
                    percorso = folderBD.SelectedPath;
            }

            return percorso;
        }

        public static List<string> ConfrontaCartella(ProgressBar pb)
        {
            var percorso = ScegliCartella();
            var files = Directory.GetFiles(percorso);
            var trovato = false; var uguali = false;
            var duplicati = new List<string>();
            var watch = Stopwatch.StartNew();

            pb.Maximum = files.Length * files.Length;

            for (int i = 0; i < files.Length; i++)
            {
                for (int j = i + 1; j < files.Length; j++)
                {
                    pb.Value = i * files.Length + j;

                    trovato = false;
                    for (int k = 0; k < duplicati.Count; k++) { if (duplicati[k] == files[j]) { trovato = false; break; } }
                    if (trovato) { continue; }

                    uguali = FilesAreEqual(files[i], files[j]);
                    if (uguali) { duplicati.Add(files[j]); }
                }
            }
            watch.Stop();
            MessageBox.Show(duplicati.Count + " file duplicati in " + watch.Elapsed.TotalSeconds + " s");

            return duplicati;
        }
    }
}
