using System;
using System.Linq;
using TStack.Log.Abstract;
using TStack.Log.Model;

namespace TStack.Log.Concrete
{
    public class ConsoleLogger : BaseLogger, ILogger
    {
        public virtual void Log(ILogModel model)
        {
            ConsoleLogModel logModel = ParseLogModel<ConsoleLogModel>(model);
            HR();
            Log($"Logger : {logModel.Information.NameOfLogger}");
            Log($"Method : {logModel.Information.MethodInfo.DeclaringType.FullName}.{logModel.Information.MethodInfo.Name}");
            Log($"Level : {logModel.Information.ExecutionLevel.ToString()}");
            if (logModel.IsException())
                Log(logModel.Information.Exception.Message);
            if (logModel.HasTimer())
                Log($"Total : {logModel.Information.Total.Value.Milliseconds} ms");
            HR();
        }
        private void Log(string value)
        {
            Console.WriteLine(value);
        }
        private void HR()
        {
            Log(string.Join("", Enumerable.Repeat("-", 50)));
        }
    }
}
