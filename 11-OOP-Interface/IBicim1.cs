using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_Interface
{
    public interface IBicim1
    {
        // ınterface yalnızca kalıtım vermek amacıyla kulluanılırlar;
        // yalnızca gövdesi olmayan metotlar ve propertiler içerebilirler.
        // Static bir değere sahip olmazlar.
        // 
        //Abstract ile Interface arasındaki miras alınırken birden fazla interface miras alabilir.
        // Bir class birden fazla interfaceden kalırım alabilirler.
        // tüm propertiler ve metotlar publictir bu nedenle erişim belirleyicisini yazmanıza gerek yoktur.
        // İsimlendirme I karakteri ike başlar

        int Numaran { get; set; }

        public void InterfaceMetod()
        {

        }
    }
}
