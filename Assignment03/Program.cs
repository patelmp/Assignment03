// See https://aka.ms/new-console-template for more information
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

/*
//Override the DisplayDetails() method to display the truck's details,
//including both common vehicle properties and truck-specific properties.{
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

}*/
/*namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Motorcycle object
            Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2022, 150.00m, 1000, "Gasoline", true);

            // Call the DisplayDetails method to display motorcycle details
            motorcycle.DisplayDetails();
        }
    }
}*/

namespace Assignment03.Tests
{
    class MotorcycleTests
    {
        static void Main(string[] args)
        {
            TestDisplayDetailsForMotorcycle();
        }

        static void TestDisplayDetailsForMotorcycle()
        {
            // Create a Motorcycle object
            Motorcycle motorcycle = new Motorcycle("XYZ", "Honda", 2022, 150, 10000, "Fuel", true);

            // Set additional motorcycle-specific properties
            motorcycle.EngineCapacity = 1500;
            motorcycle.FuelType = "Petrol";
            motorcycle.HasFairing = true;

            // Display motorcycle details
            Console.WriteLine("Motorcycle Details:");
            motorcycle.DisplayDetails();
        }
    }
}
