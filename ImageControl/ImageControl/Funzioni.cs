using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageControl
{
    class Funzioni
    {
        public bool isInside(Bitmap palette, Color color)
        {
            int sizeW = palette.Width;
            int sizeH = palette.Height;

            for (int i = 0; i < sizeH; i++)
            {
                for (int j = 0; j < sizeW; j++)
                {
                    if (palette.GetPixel(j, i) == color) return true;
                }
            }

            return false;
        }

    }
    
}
