using System;
using TStack.Proxy;
using TStack.Log.MongoDB;
using TStack.Log.SQL;
using TStack.ADO.Connection;
using TStack.Log.System;
using TStack.Log.File;
using TStack.MongoDB.Connection;
using TStack.Proxy.Models;

namespace TStack.Log
{
    public abstract class OnBoundry : MethodInterceptor
    {
        public bool ThrowExceptionOnLogging { get; set; } = false;
        public OnBoundry()
        {
            executionLoggerName = this.GetType().Name;
        }
        private ITLogger _logger;
        private string executionLoggerName;
        private LogModel _logModel;
        public void LogToMSSQL(ExecutionArgs args, ADOConnection connection, string TableName = "")
        {
            _logModel = new LogModel(args);
            _logModel.TableName = GetNameOfLog(TableName);
            Process(() =>
            {
                _logger = new SQLManager(connection);
                _logger.Log(_logModel);
            });

        }
        public void LogToQueue()
        {

        }
        public void LogToElastic()
        {

        }
        public void LogToMongoDB(ExecutionArgs args, MongoConnection mongoConnection, string collectionName = "")
        {

            _logModel = new LogModel(args);
            _logModel.CollectionName = GetNameOfLog(collectionName);
            Process(() =>
            {
                _logger = new MongoManager(mongoConnection);
                _logger.Log(_logModel);
            });
        }
        public void LogToFile(ExecutionArgs args, string folderPath)
        {
            _logModel = new LogModel(args);
            _logModel.FolderPath = folderPath;
            Process(() =>
            {
                _logger = new FileManager();
                _logger.Log(_logModel);
            });
        }

        public void LogToConsole(ExecutionArgs args)
        {
            _logModel = new LogModel(args);
            Process(() =>
            {
                _logger = new SystemLogger();
                _logger.Log(_logModel);
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
        private string GetNameOfLog(string logName = "")
        {
            if (string.IsNullOrEmpty(logName))
                return executionLoggerName;
            return logName;
        }
    }
}
