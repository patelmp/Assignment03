// See https://aka.ms/new-console-template for more information
namespace Assignment03
/*
//instantiate a Vehicle object and call its DisplayDetails method.

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Vehicle object
            Vehicle vehicle = new Vehicle("Camry", "Toyota", 2022, 70.00m);

            // Displaying vehicle details
            Console.WriteLine("Vehicle Details:");
            vehicle.DisplayDetails();
        }
    }
}
*/
/*class Program
{
    static void Main(string[] args)
    {
        *//*        // Create an instance of Vehicle
                Vehicle vehicle = new Vehicle("Camry", "Toyota", 2022, 70.00m);*//*

        // Create an instance of Car
        Car car = new Car("Camry", "Toyota", 2022, 150, 4, "Petrol", "Automatic", true);

        *//*     // Display details of the vehicle
             Console.WriteLine("Vehicle Details:");
             vehicle.DisplayDetails();*//*

        // Display details of the car
        Console.WriteLine("\nCar Details:");
        car.DisplayDetails();
    }
}*/

//Override the DisplayDetails() method to display the truck's details,
//including both common vehicle properties and truck-specific properties.
{
    using System;

    namespace Assignment03
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create instances of your classes and call their methods to demonstrate functionality
                Vehicle vehicle = new Vehicle("GenericModel", "GenericManufacturer", 2022, 100);
                vehicle.DisplayDetails();

                Console.WriteLine();

                Car car = new Car("CarModel", "CarManufacturer", 2023, 150, 4, "V8", "Automatic", true);
                car.DisplayDetails();

                Console.WriteLine();

                Truck truck = new Truck("TruckModel", "TruckManufacturer", 2021, 200, 5000, "Pickup", true);
                truck.DisplayDetails();


            }
        }
    }
}
