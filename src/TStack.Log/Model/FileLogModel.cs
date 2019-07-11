using System;
using System.Collections.Generic;
using System.Text;
using TStack.Proxy.Models;

namespace TStack.Log.Model
{
    public class FileLogModel : BaseLogModel
    {
        public FileLogModel(ExecutionArgs args, string folderPath) : base(args)
        {
            FolderPath = folderPath;
        }
        public string FolderPath { get; set; }
    }
}
