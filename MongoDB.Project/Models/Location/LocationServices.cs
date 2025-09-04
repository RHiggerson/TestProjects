using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Project.Models.Location
{
    public class LocationServices
    {
        [BsonElement("BikeSales")]
        public bool BikeSales { get; set; }
        [BsonElement("BikeRental")]
        public bool BikeRentals { get; set; }
        [BsonElement("BikeRepairs")]
        public bool BikeRepairs { get; set; }
        [BsonElement("BikeFittings")]
        public bool BikeFittings { get; set; }

    }


}

