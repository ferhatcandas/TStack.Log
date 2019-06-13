using System;
using System.Collections.Generic;
using System.Text;
using TStack.ADO.Connection;
using TStack.Proxy;
using TStack.ADO;

namespace TStack.Log.SQL
{
    internal class SQLManager : ADOManager, ITLogger
    {
        public SQLManager(ADOConnection connection) : base(connection)
        {

        }
        public void Log(LogModel logModel)
        {

        }
    }
}
