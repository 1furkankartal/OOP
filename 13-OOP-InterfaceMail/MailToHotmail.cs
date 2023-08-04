﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_InterfaceMail
{
    public class MailToHotmail : IMailService
    {
        public string From { get ; set ; }
        public string To { get ; set ; }
        public string Header { get ; set ; }
        public string Body { get ; set ; }

        public void Send()
        {
            Console.WriteLine($"hOTMAİL ÜZERİNDEN MESAJ GÖNDERİLDİ Gönderen : {From} Alıcı: {To}");
        }
    }
}
