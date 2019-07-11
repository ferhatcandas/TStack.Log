using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Log.Model;

namespace TStack.Log.Concrete
{
    public class FileLogger : BaseLogger, ILogger
    {
        public void Log(ILogModel model)
        {
            FileLogModel logModel = ParseLogModel<FileLogModel>(model);

            throw new NotImplementedException();
        }
    }
}
