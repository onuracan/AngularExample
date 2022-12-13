using IsTakipSistemi.Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace IsTakipSistemi.Core.DbContext;

public class MongoDbContext
{
    private MongoClient _mongoClient;
    private IMongoDatabase _mongoDatabase;

    public MongoDbContext(IOptions<MongoDbSettings> mongoDbSettings)
    {
        this._mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
        this._mongoDatabase = this._mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
    }


    public IMongoCollection<T> GetCollection<T>() where T : EntityBase
    {
        return this._mongoDatabase.GetCollection<T>(typeof(T).Name);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName) where T : EntityBase
    {
        return this._mongoDatabase.GetCollection<T>(collectionName);
    }
}