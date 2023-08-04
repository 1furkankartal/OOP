using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Sealed
{
    public class Book:BaseBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string AuthorName { get; set; }

        public override void Getlog()
        {
            
        }
        // Mühürlü bir metot, benden kalıtım alan sınıf beni olduğum gibi kullanabilir ama değiştiremz
        public sealed override void GetUser()
        {
           
        }


    }
}
