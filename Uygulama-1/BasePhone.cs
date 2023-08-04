using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_1
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }


        public virtual void Call()
        {
            using(SoundPlayer player = new SoundPlayer("C:\\Users\\halkbank\\Desktop\\FKARTAL\\OOP\\Uygulama-1\\sound\\default.wav")) 
            {
                player.PlaySync();
            }
        }

    }
}
