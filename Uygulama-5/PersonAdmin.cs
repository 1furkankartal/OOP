using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_5
{
    public class PersonAdmin : PersonBase
    {
        private readonly double bonus;

        public PersonAdmin(string name, int age, int hourlyWage, int workingHour, double bonus) : base(name, age, hourlyWage, workingHour)
        {
            this.bonus = bonus;
        }

        public override void CalculateWage()
        {
            base.CalculateWage();
            TotalWage += bonus;
        }


    }
}
