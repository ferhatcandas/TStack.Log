using System;
using System.Collections.Generic;
using System.Text;

namespace TStack.Log.Entities
{
    public class SqlLog
    {
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string Fullname { get; set; }
        public string Arguments { get; set; }
        public string ExceptionMessage { get; set; }
        public string Result { get; set; }
        public string NameOfLogger { get; set; }
        public string ExecutionLevel { get; set; }
        public double TotalMS { get; set; }
    }
}
