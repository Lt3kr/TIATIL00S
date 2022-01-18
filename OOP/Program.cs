using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a zoo
            zoo zoo = new zoo();
            // Start to create some locations
            int amountOfNewLocations = 3;
            Location[] locationsIds = new Location[amountOfNewLocations];
            for (int i = 0; i < amountOfNewLocations; i++)
            {
                System.Console.WriteLine($"Creating new location with id {i}");
                zoo.locationsIds.Add(i, i);
                locationsIds[i] = new Location{
                    lad = i*25,
                    lon = i*21,
                    landmark = "landmark" + i,
                    id = i,
                };
            }
            // Start to create some employees
            int amountOfNewEmployees = 3;
            Employee[] employeesIds = new Employee[amountOfNewEmployees];
            for (int i = 0; i < amountOfNewEmployees; i++)
            {
                System.Console.WriteLine($"Creating new employee with id {i}");
                employeesIds[i] = new Employee{
                    Namn = "Employee" + i,
                    id = i,
                };
            } 

            // Start to create some visitors
            int amountOfNewVisitors = 3;
            Visitor[] visitorsIds = new Visitor[amountOfNewVisitors];
            for (int i = 0; i < amountOfNewVisitors; i++)
            {
                System.Console.WriteLine($"Creating new visitors with id {i}");
                visitorsIds[i] = new Visitor{
                    Namn = "Visitor" + i,
                    id = i,
                };
            }

            // Add to our zoo
            zoo.AmountOfAnimals = amountOfNewLocations;
            zoo.AmountOfEmployees = amountOfNewEmployees;
            zoo.AmountOfVisitors = amountOfNewVisitors;
            // ! LOL fix this
            // zoo.locationsIds = locationsIds.GetValue(0);
            System.Console.WriteLine("Press to continue...");
            System.Console.ReadLine();
        }
    }
}
