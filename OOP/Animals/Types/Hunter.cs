using System;

namespace Zoo
{
    class Hunter : Animal
    {
        public bool hunting(Animal animal)
        {
            animal.isHunted = animal.isHunted!;
            if(animal.isHunted)
            {
                Console.WriteLine($"{animal.Name} is hunted");
                return true;
            }
            return false;
        }
    }
}