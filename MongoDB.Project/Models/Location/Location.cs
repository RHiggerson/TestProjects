using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace MongoDB.Project.Models.Location
{
    public class Location
    {
        [BsonId] // Marks this as the primary key (_id field in MongoDB)
        [BsonSerializer(typeof(GuidSerializer))]
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [BsonElement("Name")]
        public string? Name { get; set; }
        [BsonElement("Address")]
        public string? Address { get; set; }
        [BsonElement("City")]
        public string? City { get; set; }
        [BsonElement("State")]
        public string? State { get; set; }
        [BsonElement("ZipCode")]
        public int ZipCode { get; set; }
        [BsonElement("LocationServices")]
        public LocationServices? LocationServices { get; set; }
        [BsonElement("GroupRide")]
        public bool GroupRide { get; set; }



    }
}