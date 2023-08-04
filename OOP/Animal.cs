using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Animal
    {       
        public Animal() // Constructor (Yapıcı Metod) ctor+tab+tab
        {
            Console.WriteLine("Animal Begin");

        }

        public Animal(string animal)
        {
            Console.Write(animal);
        }

        string animalType; // Field "internal" ile program cs de de kullanılabiliyor..

        public string getAnimalType() { return animalType; }
        public void setAnimalType(string _animalType) { animalType = _animalType; }

        private int speed;

        public int Speed { 
            get
            {
                return speed;
            } set
            { 
                if(!string.IsNullOrEmpty(value.ToString()))
                    speed = value;
            } }

        public int Run { get; set; }
    }
}
