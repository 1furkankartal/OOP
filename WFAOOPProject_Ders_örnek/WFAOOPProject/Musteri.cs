﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAOOPProject
{
    public class Musteri
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }
        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
