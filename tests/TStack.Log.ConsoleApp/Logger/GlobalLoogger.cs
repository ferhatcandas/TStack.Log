using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Models;

namespace TStack.Log.ConsoleApp.Logger
{
    public class GlobalLoogger : MethodInterceptAspect
    {
        public override void OnBefore(ExecutionArgs executionArgs)
        {
        }

        public override void OnAfter(ExecutionArgs executionArgs)
        {
        }
        public override void OnException(ExecutionArgs executionArgs)
        {
        }

        public override void OnExit(ExecutionArgs executionArgs)
        {
        }

        public override void OnSuccess(ExecutionArgs executionArgs)
        {
        }
    }
}
