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
        public bool IsRented { get; set; }  // New property to track rental status

        // Declaring  Constructor
        public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
            IsRented = false;  // Initially, the vehicle is not rented
        }

        // Writing Method to display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice}");
        }
    }
}
