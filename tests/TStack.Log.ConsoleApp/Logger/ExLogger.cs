using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log.ConsoleApp.Logger
{
    public class ExLogger : MethodExceptionAspect
    {
        public override void OnException(ExecutionArgs executionArgs)
        {
        }
    }
}
