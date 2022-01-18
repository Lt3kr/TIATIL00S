using System;

namespace Zoo {
    class Pinguins : WaterAnimal{
        public void HoldBreath(){
            
        }

        public void Eat(Animal animal)
        {
            if(animal.GetType() == typeof(Shrimp))
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