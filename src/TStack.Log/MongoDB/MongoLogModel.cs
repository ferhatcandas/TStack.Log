using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using TStack.MongoDB.Entity;
using TStack.Proxy;

namespace TStack.Log.MongoDB
{
    internal class TStackMongoLog : MongoEntity
    {
        public TStackMongoLog(ExecutionArgs executionArgs)
        {
            MethodInfo = executionArgs.MethodInfo;
            Arguments = executionArgs.Arguments;
            Exception = executionArgs.Exception;
            Total = executionArgs.Total;
            Result = executionArgs.Result;
            Childs = executionArgs.Childs;
            ExecutionLevel = executionArgs.ExecutionLevel.ToString();
            LogDate = DateTime.Now;
        }
        public MethodInfo MethodInfo { get; set; }
        public object[] Arguments { get; set; }
        public Exception Exception { get; set; }
        public TimeSpan? Total { get; set; }
        public string ExecutionLevel { get; set; }
        public string LogOfName { get; set; }
        public object Result { get; set; }
        public List<ExecutionArgs> Childs { get; set; }
        public DateTime LogDate { get; set; }
    }
}
