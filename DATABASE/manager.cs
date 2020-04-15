using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM.DATABASE
{
    class manager
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("date")]
        public string Date { get; set; }
        [BsonElement("timein")]
        public string TimeIN { get; set; }
        [BsonElement("timeout")]
        public string TimeOUT { get; set; }


        public manager(string date, string timeIN, string timeOUT)
        {
            Date = date;
            TimeIN = timeIN;
            TimeOUT = timeOUT;

        }
    }
}
