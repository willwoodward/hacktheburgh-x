using MongoDB.Bson;

public class User {
    public ObjectId Id { get; set; }
    public ObjectId LeaderId { get; set; }
}