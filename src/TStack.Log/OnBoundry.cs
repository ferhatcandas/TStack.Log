using System;
using TStack.Proxy;
using TStack.ADO.Connection;
using TStack.MongoDB.Connection;
using TStack.Proxy.Models;
using TStack.Log.Abstract;
using TStack.Log.Concrete;
using TStack.Log.Model;


namespace TStack.Log
{
    public abstract class OnBoundry : MethodInterceptor
    {
        public bool ThrowExceptionOnLogging { get; set; } = false;
        private ILogger _logger;
        public OnBoundry()
        {
        }
        public void LogToMSSQL(ExecutionArgs args, ADOConnection connection, string TableName = "")
        {
            Process(() =>
            {


            });
        }
        public void LogToQueue()
        {
            Process(() =>
            {


            });
        }
        public void LogToElastic()
        {
            Process(() =>
            {


            });
        }
        public void LogToMongoDB(ExecutionArgs args, MongoConnection mongoConnection, string collectionName = "")
        {
            Process(() =>
            {
                _logger = new MongoLogger(mongoConnection);
                var log = new MongoLogModel(args, collectionName);
                _logger.Log(log);
            });
        }
        public void LogToFile(ExecutionArgs args, string folderPath)
        {
            Process(() =>
            {

            });
        }

        public void LogToConsole(ExecutionArgs args)
        {
            Process(() =>
            {
                _logger = new ConsoleLogger();
                var log = new ConsoleLogModel(args);
                _logger.Log(log);
            });
        }
        private void Process(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                if (ThrowExceptionOnLogging)
                    throw ex;
            }
           
        }
    }
}
