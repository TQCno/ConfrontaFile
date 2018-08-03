using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ImageControl
{
    class EqualElements
    {
        public string Primary { get; set; } = "";
        public string Copy { get; set; } = "";

        public EqualElements() { }
        public EqualElements(string primary, string copy) { Primary = primary; Copy = copy; }

        public Image PrimaryToImage()
        {
            return GetImageFromPath(Primary);
        }

        public Image CopyToImage()
        {
            return GetImageFromPath(Copy);
        }

        private Image GetImageFromPath(string path)
        {
            if (File.Exists(path)) { return Image.FromFile(path); }
            return null;
        }

    }
}
