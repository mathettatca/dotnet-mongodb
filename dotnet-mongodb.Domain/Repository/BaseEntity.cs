using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_mongodb.Domain.Repository
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public virtual string Id { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonElement("createdDate")]
        public DateTime CreatedDate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonElement("lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }
    }
}
