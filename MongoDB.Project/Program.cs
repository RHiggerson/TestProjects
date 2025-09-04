using MongoDB.Project.Models.Location;
using MongoDB.Project.Utilities;

class Program
{
    static async Task Main(string[] args)
    {
        var writer = new MongoWriter("mongodb://localhost:27017", "bikeshop", "entity");
        var location = new Location
        {
            Name = "Trek Bikes",
            Address = "1223 Main Street",
            City = "Jacksonville",
            State = "Florida",
            ZipCode = 32210,
            GroupRide = false,
            LocationServices = new LocationServices
            {
                BikeFittings = true,
                BikeRepairs = true,
                BikeRentals = true,
                BikeSales = true
            }

        };

        await writer.InsertLocationAsync(location);
    }
} 