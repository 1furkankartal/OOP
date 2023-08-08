using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    public class SendEmail
    {
        public static void Send()
        {
            Console.WriteLine("Send an E-mail...");
        }

        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an E-mail...{e.EmailAdress}");
        }
    }
}
