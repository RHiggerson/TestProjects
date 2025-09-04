using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDB.Project.Utilities
{

    public class MongoWriter
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public MongoWriter(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<BsonDocument>(collectionName);
        }

        public async Task InsertDocumentAsync(string name, int age, string email)
        {
            var document = new BsonDocument
        {
            { "Name", name },
            { "Age", age },
            { "Email", email },
            { "CreatedAt", DateTime.UtcNow }
        };

            await _collection.InsertOneAsync(document);
            Console.WriteLine("✅ Document inserted into MongoDB!");
        }
    }
}
