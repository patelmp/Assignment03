namespace Assignment03
// Vehicle.cs
{
    public class Vehicle
    {
        // Declaring  Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal RentalPrice { get; set; }

        // Declaring  Constructor
        public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Writing Method to display vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice}");
        }
    }
}
