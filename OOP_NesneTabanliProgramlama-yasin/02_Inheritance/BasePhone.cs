using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    public class BasePhone
    {
        protected string _brand;
        protected string _phoneType; //Protected: Sadece miras veya kalıtım yoluyla kullanılabilir.
        protected string _connectionType;

        public BasePhone() // Bu bir constructor
        {
            _phoneType = "Ahizeli Telefon";
        }
        public BasePhone(string brand, string connectionType)
        {
            _brand= brand;
            _phoneType = "Ahizeli Telefon";
            _connectionType = connectionType;
        }
        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }
        protected string Phonetype 
        { 
            get { return this._phoneType; }
            //set { this._phoneType = value; } 
        }
        protected string Connection 
        { 
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }
        public virtual string Call() // virtual: Metodu ezer. Bu da kalıtım alınan yerde bunun değişmesini sağlar.
                                     // MobilePhone.cs dosyasında 36. satıra bak. Override kullanıyorsun.
        {
            return "Çalıyor...";
        }

        public virtual string ConnectionStatus()
        {
            return "Kablolu Bağlantı.";
        }
    }
}
