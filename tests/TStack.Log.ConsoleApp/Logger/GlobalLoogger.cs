using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;

namespace TStack.Log.ConsoleApp.Logger
{
    public class GlobalLoogger : MethodInterceptAspect
    {
        public override void OnBefore(ExecutionArgs executionArgs)
        {
            Console.WriteLine("On Before");
        }

        public override void OnAfter(ExecutionArgs executionArgs)
        {
            Console.WriteLine("On After");
        }
        public override void OnException(ExecutionArgs executionArgs)
        {
            Console.WriteLine("On Exception");
        }

        public override void OnExit(ExecutionArgs executionArgs)
        {
            Console.WriteLine("On Exit");
        }

        public override void OnSuccess(ExecutionArgs executionArgs)
        {
            Console.WriteLine("On Success");
        }
    }
}
