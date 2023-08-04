using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Sealed
{
    public class CreateBook:Book
    {
        public CreateBook()
        {
            //GetUser(); Kullanılabilir ama ezilemez (Override edilemez).
            //Çünkü Book'tan alıyoruz ve Book'ta GetUser Sealed olarak tanımlandı. Eğer Basebook'tan alsaydın ezebilirdin (Sealed olmadığı için).

        }
        //public override void GetLog()           Getlog "Sealed" tanımlanmadığı için ezilebiliyor.
        //{
        //    base.GetLog();
        //}


    }
}
