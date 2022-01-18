using System;

namespace Zoo
{
    class Employee
    {
        public string Namn { get; set; }
        public int id { get; set; }
        public string Phone { get; set; }

        public void Quit()
        {
            Console.WriteLine("{0} has quit the zoo", this.Namn);
        }
    }
}