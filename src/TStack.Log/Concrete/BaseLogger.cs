using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;

namespace TStack.Log.Concrete
{
    public abstract class BaseLogger
    {
        public T ParseLogModel<T>(ILogModel model)
        {
            return (T)model;
        }
    }
}
