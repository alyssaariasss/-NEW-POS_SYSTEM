using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM.DATABASE
{
    class adminsttngs
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("age")]
        public string Age { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("contact")]
        public string Contact { get; set; }

        public adminsttngs(string name, string age, string address, string email, string contact)
        {
            Name = name;
            Age = age;
            Address = address;
            Email = email;
            Contact = contact;
        }
    }
}
