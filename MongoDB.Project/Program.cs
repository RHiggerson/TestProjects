using MongoDB.Project.Utilities;

class Program
{
    static async Task Main(string[] args)
    {
        var writer = new MongoWriter("mongodb://localhost:27017", "MyDatabase", "Users");

        await writer.InsertDocumentAsync("George", 30, "George@example.com");
    }
} 