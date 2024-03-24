/*// See https://aka.ms/new-console-template for more information

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
class Program
{
    static void Main(string[] args)
    {
        /*        // Create an instance of Vehicle
                Vehicle vehicle = new Vehicle("Camry", "Toyota", 2022, 70.00m);*/

        // Create an instance of Car
        Car car = new Car("Camry", "Toyota", 2022, 150, 4, "Petrol", "Automatic", true);

        /*     // Display details of the vehicle
             Console.WriteLine("Vehicle Details:");
             vehicle.DisplayDetails();*/

        // Display details of the car
        Console.WriteLine("\nCar Details:");
        car.DisplayDetails();
    }
}
