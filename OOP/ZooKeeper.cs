using System;

namespace Zoo
{
    class ZooKeepers : Employee{

        bool AnimalIsHungry = false;
        bool feed = false;
        public void Feed()
        {
            if(AnimalIsHungry == true)
            {
                feed = true;
            }
            if(feed == true)
            {
                Console.WriteLine("Animals have been fed");
            }
            if(AnimalIsHungry == false)
            {
                Console.WriteLine("The animals are not hungry");
            }
        }

        public void Pet()
        {
            
        }

        public dynamic HealthCheck(Animal animal)
        {
            return animal.id;
        }
    }
}