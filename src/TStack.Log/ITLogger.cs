using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;

namespace TStack.Log
{
    public interface ITLogger
    {
        void Log(LogModel logModel);
    }
}
