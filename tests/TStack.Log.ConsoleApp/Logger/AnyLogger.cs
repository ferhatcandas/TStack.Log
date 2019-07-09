using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log.ConsoleApp.Logger
{
    public class AnyLogger : MethodInterceptAspect
    {
        public override void OnBefore(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.ExecutionLevel.ToString() +" " + executionArgs.NameOfLogger);
        }

        public override void OnAfter(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.ExecutionLevel.ToString() +" " + executionArgs.NameOfLogger);
            Console.WriteLine(executionArgs.Total);
        }
        public override void OnException(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.ExecutionLevel.ToString() +" " + executionArgs.NameOfLogger);
        }

        public override void OnExit(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.ExecutionLevel.ToString() +" " + executionArgs.NameOfLogger);
        }

        public override void OnSuccess(ExecutionArgs executionArgs)
        {
            Console.WriteLine(executionArgs.ExecutionLevel.ToString() +" " + executionArgs.NameOfLogger);
        }
    }
}
