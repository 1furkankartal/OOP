﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProject3_OOP
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
                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value=0;
                }
                else if(control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            }
        }
    }
}
