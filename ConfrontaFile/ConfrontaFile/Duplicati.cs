using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrontaFile
{
    class Duplicato
    {
        public string Principale { get; set; } = "";
        public List<string> Copie { get; set; } = new List<string>();

        public Duplicato() { }
        public Duplicato(string principale, List<string> copie)
        {
            Principale = principale;
            Copie = copie;
        }

        public static bool CercaInPrincipale(List<Duplicato> duplicati, string percorso, out int i)
        {
            for (i = 0; i < duplicati.Count; i++)
                if (duplicati[i].Principale == percorso) { return true; }
            return false;
        }

        public static bool CercaInCopie(List<Duplicato> duplicati, string percorso)
        {
            foreach (var duplicato in duplicati)
                foreach (var copia in duplicato.Copie)
                    if (copia == percorso) { return true; }
            return false;
        }
    }
}
