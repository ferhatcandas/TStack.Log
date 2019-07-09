using System;
using System.Collections.Generic;
using System.Text;
using TStack.MongoDB.Connection;
using TStack.MongoDB.Repository;

namespace TStack.Log.MongoDB
{
    internal class MongoManager : MongoRepositoryBase<TStackMongoLog>, ITLogger
    {
        public MongoManager(MongoConnection mongoConnection) : base(mongoConnection)
        {
        }

        public void Log(LogModel logModel)
        {
            TStackMongoLog stackMongoLog = new TStackMongoLog(logModel.Information);
            LogToMongo(stackMongoLog, logModel.CollectionName);
        }

        private void LogToMongo(TStackMongoLog mongoLog, string collectionName)
        {
            Insert(mongoLog);
        }
    }
}
