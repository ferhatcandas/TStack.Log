using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log.ConsoleApp.Logger
{
    public class AnyLogger : MethodInterceptAspect
    {
        public override void OnBefore(ExecutionArgs executionArgs)
        {
            LogToMongoDB(executionArgs, new MongoDB.Connection.MongoConnection("localhost", 27017, "LogDatabase"), "testCol");
        }

        public override void OnAfter(ExecutionArgs executionArgs)
        {
            LogToMongoDB(executionArgs, new MongoDB.Connection.MongoConnection("localhost", 27017, "LogDatabase"), "testCol");
        }
        public override void OnException(ExecutionArgs executionArgs)
        {
            LogToMongoDB(executionArgs, new MongoDB.Connection.MongoConnection("localhost", 27017, "LogDatabase"), "testCol");
        }

        public override void OnExit(ExecutionArgs executionArgs)
        {
            LogToMongoDB(executionArgs, new MongoDB.Connection.MongoConnection("localhost", 27017, "LogDatabase"), "testCol");
        }

        public override void OnSuccess(ExecutionArgs executionArgs)
        {
            LogToMongoDB(executionArgs, new MongoDB.Connection.MongoConnection("localhost", 27017, "LogDatabase"), "testCol");
        }
    }
}
