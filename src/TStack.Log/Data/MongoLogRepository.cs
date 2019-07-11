using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Entities;
using TStack.MongoDB.Connection;
using TStack.MongoDB.Repository;

namespace TStack.Log.Data
{
    public class MongoLogRepository : MongoRepositoryBase<MongoLog>
    {
        public MongoLogRepository(MongoConnection mongoConnection) : base(mongoConnection)
        {

        }
    }
}
