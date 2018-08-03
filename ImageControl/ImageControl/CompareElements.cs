using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageControl
{
    class CompareElements
    {
        public List<string> Paths { get; set; } = new List<string>();

        public CompareElements() { }
        public CompareElements(List<string> paths)
        {
            foreach (var path in paths)
            {
                Paths.AddRange(Directory.GetFiles(path));
            }
        }

        public List<EqualElements> GetEquals(PictureBox pb1, PictureBox pb2)
        {
            var equals = new List<EqualElements>();

            for (int i = 0; i < Paths.Count; i++)
            {
                Bitmap image1 = ChangeImage(Image.FromFile(Paths[i]), pb1);
                for (int j = i + 1; j < Paths.Count; j++)
                {
                    if (IsInList(Paths[j], equals)) { continue; }
                    var image2 = ChangeImage(Image.FromFile(Paths[j]), pb2);
                    if (Same(image1, image2)) { equals.Add(new EqualElements(Paths[i], Paths[j])); }
                }
            }

            return equals;
        }

        private Bitmap ChangeImage(Image image, PictureBox pb1)
        {
            pb1.Image = image;
            return new Bitmap(image);
        }

        private bool Same(Bitmap image1, Bitmap image2)
        {
            int width1 = image1.Width;
            int height1 = image1.Height;
            int width2 = image2.Width;
            int height2 = image2.Height;

            if (width1 != width2 || height1 != height2) { return false; }

            for (int y = 0; y < height1; y++)
            {
                for (int x = 0; x < width1; x++)
                {
                    if (image1.GetPixel(x, y) != image2.GetPixel(x, y)) { return false; }
                }
            }

            return true;
        }

        private bool IsInList(string path, List<EqualElements> equals)
        {
            foreach (var equal in equals) { if (equal.Copy == path) { return true; } }
            return false;
        }
    }
}
