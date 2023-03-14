using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace unwallet.Models{
    public class ScheduledPayment{

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]        
        public string? _id {get; set;}

        [BsonElement("user_id")]
        [JsonPropertyName("user_id")]
        public int? UserId {get; set;}

        [BsonElement("name")]
        [JsonPropertyName("name")]
        public string? Name {get; set;}

        [BsonElement("category_id")]
        [JsonPropertyName("category_id")]
        public int? CategoryId {get; set;}

         [BsonExtraElements]
        public BsonDocument? AdditionalData { get; set; }
    }
}