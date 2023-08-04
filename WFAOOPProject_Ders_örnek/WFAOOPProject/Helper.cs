using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAOOPProject
{
    internal class Helper
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach(Control control in collection)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
