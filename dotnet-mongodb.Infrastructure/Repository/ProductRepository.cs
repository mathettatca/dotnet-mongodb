using dotnet_mongodb.Domain.Entities;
using MongoDB.Driver;

namespace dotnet_mongodb.Domain.Repository
{
    public class ProductRepository(IMongoCollection<Product> col) : IRepository<Product>
    {
        IMongoCollection<Product> _col = col;
        public Task CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<Product> FindAll(ReadPreference readPreference = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
