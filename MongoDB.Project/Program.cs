using MongoDB.Project.Models.Location;
using MongoDB.Project.Utilities;

class Program
{
    static async Task Main(string[] args)
    {
        var writer = new MongoWriter("mongodb://localhost:27017", "bikeshop", "entity");
        var location = new Location
        {
            Name = "Bird Leg Bikes",
            City = "Jacksonville",
            State = "Florida",
            ZipCode = 32210,
            GroupRide = true,
            LocationServices = new LocationServices
            {
                BikeFittings = true,
                BikeRepairs = true,
                BikeRentals = false,
                BikeSales = true
            }

        };

        await writer.InsertLocationAsync(location);
    }
} 