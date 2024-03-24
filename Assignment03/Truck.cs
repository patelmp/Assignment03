using Assignment03;
//Truck.cs
public class Truck : Vehicle
{
    // Additional properties specific to trucks
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor to initialize truck properties and call base class constructor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override the DisplayDetails method to display truck's details
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Call base class method to display common vehicle properties
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four-Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}
