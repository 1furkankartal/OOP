using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    public class SmartPhone : MobilePhone
    {
        public bool FrontCam { get; set; }
        public SmartPhone() // MobilePhone() adlı bir Instruction olmasaydı parametre vermeden tanımlamamda sıkıntıya girerdi.
        {
            base.HasCamera= true;
            base.IsTouched= true;
            base._phoneType = "Smart Phone";
        }
        public SmartPhone(bool frontcam)
        {
            base.HasCamera = true;
            base.IsTouched = true;
            base._phoneType = "Smart Phone";
            FrontCam=frontcam;
        }
        public SmartPhone(string brand, string connectiontype, bool hasCamera, bool istouched, bool frontcam):base(hasCamera,istouched,brand,connectiontype)
        {
            base._phoneType = "Smart Phone";
            this.FrontCam= true;
        }
        public string DoVideoCall()
        {
            return "Calling...";
        }
    }
}
