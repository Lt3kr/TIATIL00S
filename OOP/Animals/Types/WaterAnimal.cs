using System;

namespace Zoo
{
    class WaterAnimal : Animal
    {
        public void Swims()
        {
            Console.WriteLine($"{this.Name} is swimming");
        }
    }
}