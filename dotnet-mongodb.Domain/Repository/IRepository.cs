using dotnet_mongodb.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_mongodb.Domain.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IMongoCollection<T> FindAll(ReadPreference readPreference = null);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);
    }
}
