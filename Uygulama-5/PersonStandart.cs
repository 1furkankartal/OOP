using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_5
{
    public class PersonStandart : PersonBase
    {
        private const double _hourlyOverTimeWage = 250; // Const Değiştirilemez değerlere eklenir.
        public PersonStandart(string name, int age, int hourlyWage, int workingHour) : base(name, age, hourlyWage, workingHour)
        {

        }

        public double OvertimeWate { get; set; }

        public override void CalculateWage()
        {
 
            if (WorkingHour > 160)
            {
                TotalWage = 160 * Hourlywage;
                int overtime = WorkingHour - 160;
                OvertimeWate = overtime * _hourlyOverTimeWage;
                TotalWage += OvertimeWate;
            }
            else
            {
                base.CalculateWage();
            }
            
        }

    }
}
