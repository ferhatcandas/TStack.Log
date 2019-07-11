using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Log.Data;
using TStack.Log.Entities;
using TStack.Log.Model;
using TStack.MongoDB.Connection;
using TStack.MongoDB.Repository;

namespace TStack.Log.Concrete
{
    public class MongoLogger : BaseLogger, ILogger
    {
        private readonly MongoLogRepository _mongoLogRepository;
        public MongoLogger(MongoConnection mongoConnection)
        {
            _mongoLogRepository = new MongoLogRepository(mongoConnection);
        }
        public void Log(ILogModel model)
        {
            //string collectionName = "";
            MongoLogModel logModel = ParseLogModel<MongoLogModel>(model);
            MongoLog log = logModel.ToMongoLog();
            //if (logModel.HasCollectionName())
                //collectionName = logModel.CollectionName;
            //else
                //collectionName = $"TStackMongoDBLogger";

            _mongoLogRepository.Insert(log);
        }
    }
}
