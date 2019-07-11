using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log.Model
{
    public abstract class BaseLogModel : ILogModel
    {
        public BaseLogModel(ExecutionArgs args)
        {
            Information = args;
        }
        public ExecutionArgs Information { get; private set; }
        public bool IsException()
        {
            if (Information.Exception != null && Information.Exception.InnerException != null)
                return true;
            return false;
        }
        public bool HasTimer()
        {
            if (Information.Total != null && Information.ElapsedTime.IsRunning == false && Information.ExecutionLevel == ExecutionType.OnExit && IsException() == false)
                return true;
            return false;
        }
        public bool HasResult()
        {
            if (Information.Result != null && Information.ExecutionLevel == ExecutionType.OnAfter)
                return true;
            return false;
        }
        public bool HasArguments()
        {
            if (Information.Arguments != null)
                return true;
            return false;
        }
    }
}
