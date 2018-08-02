using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ImageControl
{
    class Funzioni
    {
        public void ScegliImmagine(PictureBox picture, Label name)
        {
            var dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(dialog.FileName);
                picture.Image = image;
                name.Text = ((dialog.FileName.Split('\\'))[dialog.FileName.Split('\\').Length - 1]).Split('.')[0];
            }
        }
    }
}
