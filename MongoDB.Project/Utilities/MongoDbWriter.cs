using MongoDB.Driver;
using MongoDB.Project.Models.Location;

namespace MongoDB.Project.Utilities
{

    public class MongoWriter
    {


        private readonly IMongoCollection<Location> _collection;

        public MongoWriter(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<Location>(collectionName);
        }

        public async Task InsertLocationAsync(Location location)
        {
             if (location.Id == Guid.Empty)  
            location.Id = Guid.NewGuid(); // ensure key is always set

            await _collection.InsertOneAsync(location);
            Console.WriteLine("✅ User object inserted into MongoDB!");
        }
    }
}
