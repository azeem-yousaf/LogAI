namespace DBInterface.MongoDbInterface;

public interface IMongoDbRepository<T>
{
    public Task InsertAsync(T entity);
    public Task<T> GetByIdAsync(string id);
    public Task UpdateAsync(string id, T entity);
    public Task DeleteAsync(string id);
    public Task<List<T>> GetAllAsync();
}