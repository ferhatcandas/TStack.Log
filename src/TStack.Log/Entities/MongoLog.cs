using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Model;
using TStack.MongoDB;
using TStack.MongoDB.Entity;
using TStack.Proxy.Models;

namespace TStack.Log.Entities
{
    [CollectionName("TStackMongoDBLogger")]
    public class MongoLog : MongoEntity
    {
        public string MethodBaseName { get; set; }
        public string MethodName { get; set; }
        public string Arguments { get; set; }
        public ExceptionModel Exception { get; set; }
        public double Total { get; set; }
        public string NameOfLogger { get; set; }
        public object Result { get; set; }
        public string ExecutionLevel { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedAt { get; set; }
    }
}
