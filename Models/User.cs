using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace UserApi.Models
{
  public class User
  {
    [BsonId]
    public ObjectId Id {get; set;}
    public string Name {get; set;}
    public string LastName {get; set;}
    public string Category {get; set;}
    public DateTime DateCreated {get; set;}
  }
}
