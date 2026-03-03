using dotnet_mongodb.Domain.Repository;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_mongodb.Domain.Entities
{
    public class Product : BaseEntity
    {


        [BsonElement("name")]
        public string Name { get; set; } = default!;

        [BsonElement("price")]
        public decimal Price { get; set; }
    }
}
