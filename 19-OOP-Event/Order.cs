using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    //Evnet deklare edebilmem için delegate yapısına ihtiyacım var.
    // 1- Deleate oluştur 

    public delegate void OrderEventHandler();

    public class Order // Publisher
    {
        // 2- Evente delegate bildir
        //Syntax Acces Modifier - event - delegate name - event name
        public event OrderEventHandler OnCreated;


        public void Create()
        {

            

            Console.WriteLine("Order Created!");

            //Böyle bir yapıyı en iyi şekilde tasarlayabilmek için publisher/subscriber pattern kullanmamız daha doğrudur.

            SendEmail.Send(); // Subscriber
            SendSMS.Send(); // Subscriber

            // Event tetikleme eğer delegate null değilse
            if (OnCreated!=null)
            {
                OnCreated();
            }

           // OnCreated.Invoke();

        }

    }
}
