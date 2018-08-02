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
        private static bool IsInside(Bitmap palette, Color color)
        {
            int sizeW = palette.Width;
            int sizeH = palette.Height;
            var argb = color.ToArgb();

            for (int i = 0; i < sizeH; i++)
            {
                for (int j = 0; j < sizeW; j++)
                {
                    var colore = palette.GetPixel(j, i).ToArgb();
                    if (colore == argb) return true;
                }
            }

            return false;
        }

        public static void ScegliImmagine(PictureBox picture, Label name)
        {
            var dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.bmp, *.png) | *.jpg; *.jpeg; *.jpe; *.bmp; *.png";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(dialog.FileName);
                picture.Image = image;
                name.Text = ((dialog.FileName.Split('\\'))[dialog.FileName.Split('\\').Length - 1]).Split('.')[0];
            }
        }

        public static void Verifica(Button btn, PictureBox pbPalette)
        {
            if (pbPalette.Image == null) { return; }

            var dialog = new ColorDialog();
            var color = Color.White;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;

                if (IsInside(new Bitmap(pbPalette.Image), color))
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
            }
        }


    }

}
