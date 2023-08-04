using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Inheritance
{
    internal class SmartPhone:MobilePhone
    {
        public bool FrontCam { get; set; }

        public SmartPhone()
        {
            base.HasCamera= true;
            base.IsTouched= true;
            base._phoneType = "Smart Phone";
        }

        public SmartPhone(bool frontCam)
        {
            base.HasCamera = true;
            base.IsTouched = true;
            base._phoneType = "Smart Phone";
            FrontCam = frontCam;
        }

        public string DoVideoCall()
        {
            return "Calling...";
        }
    }
}
