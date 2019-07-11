using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Log.Model;

namespace TStack.Log.Concrete
{
    public class DapperLogger : BaseLogger, ILogger
    {
        public void Log(ILogModel model)
        {
            SqlLogModel logModel = ParseLogModel<SqlLogModel>(model);
            throw new NotImplementedException();
        }
    }
}
