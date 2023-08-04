using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Inheritance
{
    internal class MobilePhone : BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            _phoneType = "Mobile Phone";
        }

        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType)
        {
                this.HasCamera = hasCamera;
                this.IsTouched = isTouched; 

                this.Brand = brand;
                base._phoneType = "mobile phone";
                this.ConectionType= connectionType;

        }

        public string TakePhoto()
        {
            if(this.HasCamera)
            {
                return "take phone";
            }
            else 
            {
                return "dont take phone";
            }

        }

        public override string Call()
        {
            return "poliformik çalıyor.."+ base.Call();
           // return base.Call();
        }

        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();
        }

    }
}
