using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy.Models;

namespace TStack.Log.Model
{
    public class SqlLogModel : BaseLogModel
    {
        public SqlLogModel(ExecutionArgs args, string tableName) : base(args)
        {
            TableName = tableName;
        }
        public string TableName { get; set; }
    }
}
