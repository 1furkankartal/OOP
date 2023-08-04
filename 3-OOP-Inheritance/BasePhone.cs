using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Inheritance
{
    internal class BasePhone
    {
        public BasePhone()
        {
            _phoneType = "Ahize Telefon";
        }

        public BasePhone(string brand, string phoneType)
        {
            _brand = brand;
            _phoneType = phoneType;
            // _connectionType = connectionType;
        }

        protected string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public string Brand {
            get { return this._brand; }
            set { this._brand = value; }
        }

        protected string PhoneType {
            get { return this._phoneType; }
            
        }

        protected string ConectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        public virtual string Call()
        {
            return "Çalıyor..";
        }

        public virtual string ConnectionStatus()
        {
            return "Kablolu Bağlantı";
        }

    }
}
