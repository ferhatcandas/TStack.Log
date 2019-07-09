using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TStack.Proxy;
using TStack.Proxy.Aspects;
using TStack.Proxy.Models;

namespace TStack.Log
{
    public abstract class MethodTimingAspect : OnBoundry, IBefore, IAfter, ISuccess, IExit
    {
        internal static List<ExecutionArgs> _memoryThreads = new List<ExecutionArgs>();
        public static List<ExecutionArgs> Timings = new List<ExecutionArgs>();
        public void OnBefore(ExecutionArgs executionArgs)
        {
            AddToMemory(executionArgs);
        }
        public void OnAfter(ExecutionArgs executionArgs)
        {
            UpdateMemory(executionArgs);
            foreach (var item in _memoryThreads.Where(x => x.ActiveThread.IsAlive == false))
                Timings.Add(item);
        }
        public abstract void OnSuccess(ExecutionArgs executionArgs);
        public void OnExit(ExecutionArgs executionArgs)
        {
            DeleteThreads();
        }
        private void AddToMemory(ExecutionArgs executionArgs)
        {
            var existThread = _memoryThreads.FirstOrDefault(x => x.ActiveThread.ManagedThreadId == executionArgs.ActiveThread.ManagedThreadId);
            //base log
            if (existThread == null)
            {
                _memoryThreads.Add(executionArgs);

            }
            else //child log
            {
                if (existThread.Childs == null)
                    existThread.Childs = new List<ExecutionArgs>();
                existThread.Childs.Add(executionArgs);
            }
        }
        private void UpdateMemory(ExecutionArgs executionArgs)
        {
            var process = _memoryThreads.FirstOrDefault(x => x.ActiveThread.ManagedThreadId == executionArgs.ActiveThread.ManagedThreadId);
            process.Fill(executionArgs);
        }
        private void DeleteThreads()
        {
            List<ExecutionArgs> removeList = new List<ExecutionArgs>();
            foreach (var item in _memoryThreads)
            {
                if (item.ActiveThread != null)
                {
                    if (item.ActiveThread.IsAlive == false)
                    {
                        removeList.Add(item);
                    }
                }
            }
            foreach (var item in removeList)
            {
                _memoryThreads.Remove(item);
                Timings.Remove(item);
            }
        }
    }
}
