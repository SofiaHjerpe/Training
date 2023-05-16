using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;

namespace Training.Models
{
    public class MyTrainings
    {

        public ObjectId Id { get; set; }
        public string Exercise { get; set; }
        public DateTime Date { get; set; }

        public List<SelectListItem> Exerc { set; get; }

        public int Distance { get; set; }
    }
}
