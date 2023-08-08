using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    //C# event kullanımında yemi bir delegate türü tanımlamamıza gerek kalması için standart EventHandler Delegate türünü sağlar.

    public delegate void EventHandler(object sender, EventArgs e);
    //1 sneder: eventi başlatan nesneye bir referans tutar.
    //2- eventargs: uygulama için geçerli olan durum bilgisini tutar.

    //2.1 Event data gönderme Tanımlama

    public class OrderEH
    {
        public event EventHandler<OrderEventArgs> OnCreated;

       // public event EventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("Order Created Event Handler..");
            if (OnCreated!=null)
            {
                OnCreated(this, new OrderEventArgs { EmailAdress="1furkankartal@gmail.com", PhoneNumber="5369635624"});
            }
        }
    }
}
