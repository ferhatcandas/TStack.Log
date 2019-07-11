using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Model;

namespace TStack.Log.Abstract
{
    public interface ILogger
    {
        void Log(ILogModel model);
    }
}
