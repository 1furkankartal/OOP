using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Sealed
{
    public class BaseBook
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual void Getlog()
        {

        }

        public virtual void GetUser()
        {

        }
    }
}
