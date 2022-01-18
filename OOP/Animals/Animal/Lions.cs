using System;

namespace Zoo{
    class Lion : Hunter
    {


        public void Eat(Animal animal)
        {
            if(animal.GetType() == typeof(Zebra))
            {
                Console.WriteLine($"{this.Name} is eating {animal.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} is not eating {animal.Name}");
            }
        }
    }
}