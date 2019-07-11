using System;
using System.Collections.Generic;
using System.Text;

namespace TStack.Log.Model
{
    public class ExceptionModel
    {
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string HelpLink { get; set; }
        public ExceptionModel InnerException { get; set; }
    }
}
