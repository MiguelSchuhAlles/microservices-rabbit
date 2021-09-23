using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
//using Z.EntityFramework.Extensions;

namespace MicroRabbit.Transfer.Data
{
    public class EFCommandInterceptor : DbCommandInterceptor
    {
        //public override void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        //{
        //    base.ReaderExecuted(command, interceptionContext);

        //    var a = interceptionContext.Result.GetSchemaTable();
        //    var b = interceptionContext.Result.GetColumnSchema();
        //    var c = interceptionContext.Result.GetSchemaTable();
        //    var d = interceptionContext.Result.GetType();

        //    var y = interceptionContext.EventData;

        //    LogInfo("EFCommandInterceptor.ReaderExecuted", interceptionContext.Result.ToString(), command.CommandText);
        //}

        // runs before a query is executed
        public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
            return result;
        }


        // runs after a query is excuted
        public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
        {
            var a = result.GetSchemaTable();
            var b = result.GetColumnSchema();
            var c = result.GetSchemaTable();
            var d = result.GetType();

            return result;
        }
    }
}


