using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    public class MobilePhone : BasePhone  // : koyup BasePhone'dan miras al dedik. BİR CLASS BİRDEN FAZLA KALITIM ALMAZ.
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }
        public MobilePhone()
        {
            base._phoneType = "Mobile Phone";
        }
        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType)
        {
            this.HasCamera = hasCamera;
            this.IsTouched = isTouched;
            base._phoneType = "Mobile Phone";
            base.Brand= brand;
            base._connectionType= connectionType;
        }
        public string TakePhoto()
        {
            if(this.HasCamera)
            {
                return "You can take e photo";
            }
            else
            {
                return "There is not Camera";
            }
        }
        public override string Call() //Override, miras alınan atanın özelliğini ezerken kullanılır.
                                      //Ezilen metot virtual olmak zorundadır.
        {
            return "Poliformik " + base.Call(); //Ezdiğimiz için artık bu görünecek. base.Call dediğimizde
            // Atadan geleni de "Poliformik" ifadesinin yanına ekledi.
        }
        public override string ConnectionStatus()
        {
            return "Kablosuz Bağlantı";
        }
        public override string ToString() // Override ile ToString() Metodunu değiştirdik. (Ezdik)
        {
            return $"Telefonun markası: {Brand} \nTelefonun tipi: {Phonetype}";
        }
    }
}
