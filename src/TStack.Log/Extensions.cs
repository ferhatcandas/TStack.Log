using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TStack.Log.Entities;
using TStack.Log.Model;

namespace TStack.Log
{
    internal static class Extensions
    {
        internal static MongoLog ToMongoLog(this MongoLogModel model)
        {
            return new MongoLog()
            {
                Arguments = model.HasArguments() ? model.Information.Arguments.ToJson() : null,
                Total = model.HasTimer() ? model.Information.Total.Value.TotalMilliseconds : 0,
                Exception = model.IsException() ? model.Information.Exception.InnerException.ToExceptionModel() : null,
                ExecutionLevel = model.Information.ExecutionLevel.ToString(),
                MethodBaseName = model.Information.MethodInfo.DeclaringType.FullName,
                MethodName = model.Information.MethodInfo.Name,
                NameOfLogger = model.Information.NameOfLogger,
                CreatedAt = DateTime.Now,
                Result = model.HasResult() ? model.Information.Result : null
            };
        }
        internal static SqlLog ToSqlLog(this SqlLogModel model)
        {
            return new SqlLog()
            {
                Arguments = model.HasArguments() ? model.Information.Arguments.ToJson() : "",
                ExceptionMessage = model.IsException() ? model.Information.Exception.InnerException.Message : "",
                ExecutionLevel = model.Information.ExecutionLevel.ToString(),
                Fullname = model.Information.MethodInfo.DeclaringType.FullName,
                MethodName = model.Information.MethodInfo.Name,
                NameOfLogger = model.Information.NameOfLogger,
                Result = model.HasResult() ? model.Information.Result.ToJson() : "",
                TotalMS = model.HasTimer() ? model.Information.Total.Value.TotalMilliseconds : 0,
            };
        }
        internal static ExceptionModel ToExceptionModel(this Exception exception)
        {
            return new ExceptionModel
            {
                HelpLink = exception.HelpLink,
                Message = exception.Message,
                Source = exception.Source,
                StackTrace = exception.StackTrace,
                InnerException = exception.InnerException != null ?
                new ExceptionModel
                {
                    HelpLink = exception.InnerException.HelpLink,
                    Message = exception.InnerException.Message,
                    Source = exception.InnerException.Source,
                    StackTrace = exception.InnerException.StackTrace,
                } : null
            };
        }
        internal static string ToJson(this object model) => JsonConvert.SerializeObject(model);
    }
}
