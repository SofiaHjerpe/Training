using MongoDB.Bson;

namespace Training.Models
{
    public class MyTrainings
    {

        public ObjectId Id { get; set; }
        public string Exercise { get; set; }
        public DateTime Date { get; set; }

        public int Distance { get; set; }
    }
}
