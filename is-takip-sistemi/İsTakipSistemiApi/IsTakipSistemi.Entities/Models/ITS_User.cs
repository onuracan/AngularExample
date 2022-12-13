using IsTakipSistemi.Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IsTakipSistemi.Entities.Models;

[Serializable]
public partial class ITS_USER : EntityBase
{
    [System.Runtime.Serialization.DataMember]
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string UserName { get; set; } 
    public string Password { get; set; }
    public string NameAndSurname { get; set; }
}
