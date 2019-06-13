using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;

namespace TStack.Log.ConsoleApp.Logger
{
    public class ExLogger : MethodExceptionAspect
    {
        public override void OnException(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.Exception.Message);
        }
    }
}
