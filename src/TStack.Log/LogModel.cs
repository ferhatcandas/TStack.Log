using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log
{
    public class LogModel
    {
        public LogModel(ExecutionArgs args)
        {
            Information = args;
        }
        public ExecutionArgs Information { get; set; }
        public virtual string TableName { get; set; }
        public virtual string CollectionName { get; set; }
        public virtual string FolderPath { get; set; }
    }
}
