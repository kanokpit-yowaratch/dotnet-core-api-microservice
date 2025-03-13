using MongoDB.Bson.Serialization.Attributes;

namespace ProductService.Model
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("topic")]
        public string Topic { get; set; } = string.Empty;
    }
}
