using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using TStack.Proxy;
using TStack.Proxy.Aspects;

namespace TStack.Log
{
    public abstract class MethodInterceptAspect : OnBoundry, IBefore, IAfter, IException, ISuccess, IExit
    {
        public abstract void OnBefore(ExecutionArgs executionArgs);
        public abstract void OnAfter(ExecutionArgs executionArgs);
        public abstract void OnSuccess(ExecutionArgs executionArgs);
        public abstract void OnException(ExecutionArgs executionArgs);
        public abstract void OnExit(ExecutionArgs executionArgs);
    }
}
