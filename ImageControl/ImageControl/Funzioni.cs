using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageControl
{
    class Funzioni
    {

        public static void SelectFolder(ComboBox cb, List<Extension> extensions, bool cleatList)
        {
            using (var folderBD = new FolderBrowserDialog())
            {
                DialogResult result = folderBD.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBD.SelectedPath))
                {
                    if (cleatList) { Data.FolderPaths.Clear(); }
                    Data.FolderPaths.Add(folderBD.SelectedPath);
                    AddNames(cb, extensions);
                }
            }
        }

        public static void AddNames(ComboBox cb, List<Extension> extensions)
        {
            var paths = Directory.GetFiles(Data.FolderPaths[Data.FolderPaths.Count - 1]);

            foreach (var path in paths)
            {
                bool find = false;
                foreach (var extension in extensions) { if (extension.ToString() == Path.GetExtension(path)) { find = true; break; } }
                if (!find) { continue; }
                cb.Items.Add(Path.GetFileName(path));
            }

            if (paths.Length > 0 && cb.SelectedIndex < 0) { cb.SelectedIndex = 0; }
        }

        public static bool GetExtensions(CheckBox png, CheckBox jpg, CheckBox btm, List<Extension> extensions)
        {
            bool bPng = png.Checked, bJpg = jpg.Checked, bBtm = btm.Checked;

            if (!bPng && !bPng && !bBtm) { return false; }
            extensions = new List<Extension>();

            if (bPng) { extensions.Add(new Extension(Ext.PNG)); }
            if (bJpg) { extensions.Add(new Extension(Ext.JPG)); }
            if (bBtm) { extensions.Add(new Extension(Ext.BTM)); }

            return true;
        }
    }

}
