using MongoDB.Bson;
using MongoDB.Driver;

namespace DBInterface.MongoDbInterface;

public class MongoDbRepository<T> : IMongoDbRepository<T>
{
    private readonly IMongoCollection<T> _collection;
    
    public MongoDbRepository(IDbConnectionString dbConnection, string databaseName, string collectionName)
    {
        var client = new MongoClient(dbConnection.ConnectionString);
        var database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<T>(collectionName);
    }
    
    public async Task InsertAsync(T entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task<T> GetByIdAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task UpdateAsync(string id, T updatedEntity)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
        await _collection.ReplaceOneAsync(filter, updatedEntity);
    }

    public async Task DeleteAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
        await _collection.DeleteOneAsync(filter);
    }
}