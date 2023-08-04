using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    public abstract class MuzikAleti
    {
        public string Markası { get; set; }
        public string Aciklamasi { get; set; }

        public abstract string Cal();
    }
}
