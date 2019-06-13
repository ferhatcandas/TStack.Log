using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy;

namespace TStack.Log.ConsoleApp.Logger
{
    public class TimeLog : MethodTimingAspect
    {
        public override void OnSuccess(ExecutionArgs executionArgs)
        {
            foreach (var item in Timings)
            {
                ConsoleLog(item);
                if (item.HasChilds())
                {
                    foreach (var child in item.Childs)
                    {
                        ConsoleLog(child);
                    }
                }
                ConsoleHR();
            }
        }
        private void ConsoleLog(ExecutionArgs executionArgs)
        {
            Console.WriteLine($"Log Name is {executionArgs.NameOfLogger} Instance Name {executionArgs.MethodInfo.ReflectedType.Name} > {executionArgs.MethodInfo.Name } total ms : {executionArgs.Total.Value.TotalMilliseconds}");
        }
        private void ConsoleHR()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        }
    }
}
