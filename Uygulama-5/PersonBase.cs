using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_5
{//https://twitter.com/mecburlarhani/status/1686789981031854084?s=20
    public class PersonBase
    {
      
        public PersonBase(string name, int age, int hourlyWage, int workingHour)
        {
            this.Name = name;
            this.BirthDate= age;
            this.Hourlywage= hourlyWage;
            this.WorkingHour= workingHour;


        }

        private string _name;
        private int _age;
        private int _hourlyWage;
        private int _workinghour;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name=value.ToUpper();
            }
        }

        public int BirthDate {

            set
            {
                if(DateTime.Now.Year-value>18)
                {
                    _age = DateTime.Now.Year - value;
                }
            }
        }
        public int Hourlywage {
           protected get
            {
                return _hourlyWage;
            }
            set
            {
                if (value >= 200) { _hourlyWage = value; }
                else { _hourlyWage = 200; }
            }
        }
        public int WorkingHour {
            get { return _workinghour; }
            set
            {
                if(value > 0) 
                {
                    _workinghour = value;
                }
            }
        }

        public double TotalWage { get; protected set; }


         public virtual void CalculateWage() 
        {
            Console.WriteLine("maaş hesaplanıyor");
            TotalWage = WorkingHour * _hourlyWage;
        }

        public override string ToString()
        {
            return Name + " " + " " + TotalWage;
        }

    }
}
