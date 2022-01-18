using System;

namespace Zoo
{
    class Location
    {
        public int lad { get; set; }
        public int lon { get; set; }
        public string landmark { get; set; }
        public int id { get; set; }
        public string name { get; set; }

        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping", this.name);
        }

        public void Eat()
        {
            Console.WriteLine("{0} is eating", this.name);
        }

    }
}