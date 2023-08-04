using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAOOPProject2
{
    internal class Calisan
    {
        private string ad;
        public string Ad { get { return ad; } set 
            {
                if (value.Length > 2)
                {
                    ad=value;
                }
                else
                {
                    throw new Exception("Ad 3 karakterden fazla olamaz");
                }
            } 
        }

        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set
            { 
                if(value.Length>1)
                {
                    soyad=value;
                }
                else
                {
                    throw new Exception("soyad 2 karakterden az olamaz");
                }
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
                if (value.EndsWith("@bilgeadam.com"))
                {
                    email=value;
                }
                else
                {
                    throw new Exception("mail doğru formatta değil");
                }
            }
        }

        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (!string.IsNullOrEmpty(value)&& value.All(char.IsDigit))
                {
                    telefon=value;
                }
                else
                {
                    throw new Exception("Telefon boş geçilemez ve sadece rakamlardan ouşur");
                }
            }
        }

        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set 
            {
                if((DateTime.Now.Year - value.Year) > 18)
                {
                    dogumTarihi = value;
                }
                else
                {
                    throw new Exception("yaş 18 den küçük olamaz");
                }
            }
        }

        public String Cinsiyet { get; set; }

        public string Bilgilerigetir()
        {
            return this.ad + " " + this.soyad;
        }

    }
}
