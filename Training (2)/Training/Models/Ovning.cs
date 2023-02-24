using MongoDB.Bson;
using System;

namespace Training.Models
{
    public class Ovning
    
      {
        public ObjectId Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

    }
}
