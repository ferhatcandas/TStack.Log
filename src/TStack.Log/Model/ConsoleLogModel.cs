using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Proxy.Models;

namespace TStack.Log.Model
{
    public class ConsoleLogModel : BaseLogModel
    {
        public ConsoleLogModel(ExecutionArgs args) : base(args)
        {
        }
    }
}
