using System;

namespace Zoo
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool LandLiving { get; set; }
        public bool MeatEater { get; set; }
        public int health { get; set; }
        public int hunger { get; set; }
        public int thirst { get; set; }
        public int id { get; set; }
        public dynamic locationId { get; set;}
        public bool isHunted { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0} is eating", this.Name);
        }

        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping", this.Name);
        }
    }

}