using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;
using System.ComponentModel;
using System.Reflection;
using Training.Models;

namespace Training
{
    public class Database
    {
        MongoClient dbClient = new MongoClient();
        private IMongoDatabase GetDb()
        {
            return dbClient.GetDatabase("ovningDB");

        }
        public async Task<List<Ovning>> GetOvningarAsync()
        {
            return await GetDb().GetCollection<Ovning>("Exercise")
                .Find(o => true)
                .ToListAsync();

        }


        public async Task SaveExercise(Ovning ovning)
        {
            await GetDb().GetCollection<Ovning>("Exercise")
                 .InsertOneAsync(ovning);
        }
        public async Task<Ovning> GetOvning(string Id)
        {
            ObjectId _id = new ObjectId(Id);
            var ovning = await GetDb().GetCollection<Ovning>("Exercise")
                .Find(o => o.Id == _id)
                .SingleOrDefaultAsync();
            return ovning;
        }

        public async Task<List<MyTrainings>> GetTrainingsAsync()
        {
            return await GetDb().GetCollection<MyTrainings>("Training")
                .Find(t => true)
                .ToListAsync();

        }
        public async Task SaveTraining(MyTrainings Training)
        {
            await GetDb().GetCollection<MyTrainings>("Training")
                .InsertOneAsync(Training);
        }


        public async Task<Ovning> GetExerciseById(string id)
        {
            ObjectId _id = new ObjectId(id);
            var exercise = await GetDb().GetCollection<Ovning>("Exercise")
                .Find(e => e.Id == _id)
                .SingleOrDefaultAsync();
            return exercise;

        }


        public async Task DeleteExercise(string id)
        {
            ObjectId _id = new ObjectId(id);
            await GetDb().GetCollection<Ovning>("Exercise")
                .DeleteOneAsync(e => e.Id == _id);
        }



    }
}