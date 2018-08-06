using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrontaFile
{
    class Dati
    {
        public static List<string> ImmaginiExt = new List<string>() { "png", "jpg" };
        public static List<string> VideoExt = new List<string>() { "mp4" };
        public static List<string> AltroExt = new List<string>() { };

        public static bool Immagini = true;
        public static bool Video = true;
        public static bool Altro = true;

        public static List<string> PercorsiFile = new List<string>();

        public static List<Duplicato> Coppie = new List<Duplicato>();
    }
}
