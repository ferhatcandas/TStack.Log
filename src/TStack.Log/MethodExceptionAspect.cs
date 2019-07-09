using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;
using TStack.Proxy.Aspects;

namespace TStack.Log
{
    public abstract class MethodExceptionAspect :OnBoundry, IException
    {
        public abstract void OnException(ExecutionArgs executionArgs);
    }
}
