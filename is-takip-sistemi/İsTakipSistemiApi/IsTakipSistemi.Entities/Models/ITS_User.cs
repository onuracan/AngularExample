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

    [System.Runtime.Serialization.DataMember]
    public string UserName { get; set; }

    [System.Runtime.Serialization.DataMember]
    public string Password { get; set; }

    [System.Runtime.Serialization.DataMember]
    public string NameAndSurname { get; set; }
}
