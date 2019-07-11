using System;
using System.Collections.Generic;
using System.Text;
using TStack.Log.Abstract;
using TStack.Proxy.Models;

namespace TStack.Log.Model
{
    public class MongoLogModel : BaseLogModel
    {
        public MongoLogModel(ExecutionArgs args,string collectionName) : base(args)
        {
            CollectionName = collectionName;
        }
        public string CollectionName { get; private set; }
        public bool HasCollectionName()
        {
            if (!string.IsNullOrEmpty(CollectionName))
                return true;
            return false;
        }
    }
}
