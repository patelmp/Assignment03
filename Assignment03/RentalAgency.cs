using Assignment03;

public class RentalAgency
{
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
        Console.WriteLine($"Vehicle {vehicle.Model} added to the fleet.");
    }

    // Method to remove a vehicle from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        if (Fleet.Remove(vehicle))
        {
            Console.WriteLine($"Vehicle {vehicle.Model} removed from the fleet.");
        }
        else
        {
            Console.WriteLine($"Vehicle {vehicle.Model} not found in the fleet.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle)
    {
        // Check if the vehicle is available in the fleet
        foreach (Vehicle v in Fleet)
        {
            if (v == vehicle && !v.IsRented)
            {
                v.IsRented = true; // Mark the vehicle as rented
                TotalRevenue += v.RentalPrice; // Increase total revenue
                Console.WriteLine($"Vehicle {v.Model} rented. Total revenue: {TotalRevenue:C}");
                return;
            }
        }

        Console.WriteLine($"Vehicle {vehicle.Model} not available for rent.");
    }


}
