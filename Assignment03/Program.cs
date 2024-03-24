// See https://aka.ms/new-console-template for more information

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
