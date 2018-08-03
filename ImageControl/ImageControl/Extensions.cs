using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageControl
{
    enum Ext
    {
        PNG,
        JPG,
        BTM,
    }

    class Extension
    {
        public Ext Ext { get; set; } = Ext.PNG;

        public Extension() { }
        public Extension(Ext ext) { Ext = ext; }

        public override string ToString()
        {
            return '.' + Ext.ToString().ToLower();
        }
    }
}
