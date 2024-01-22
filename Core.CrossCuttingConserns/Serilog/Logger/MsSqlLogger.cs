using Core.CrossCuttingConserns.Serilog.ConfigurationModel;
using Core.CrossCuttingConserns.Serilog.Messages;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Serilog.Logger
{
    public class MsSqlLogger:LoggerServiceBase
    {
        public MsSqlLogger(IConfiguration configuration)
        {
            MsSqlConfiguration logConfig = configuration.GetSection("SeriLogConfiguration:MsSqlConfiguration").Get<MsSqlConfiguration>() ?? throw new Exception(SerilogMessages.NullOptionMessage);
            MSSqlServerSinkOptions sinkOptions = new()
            {
                TableName = logConfig.TableName,
                AutoCreateSqlDatabase = logConfig.AutoCreateSqlTable
                

            };
            ColumnOptions columnOptions = new();
            global::Serilog.Core.Logger seriLogConfig = new LoggerConfiguration().WriteTo.MSSqlServer(logConfig.ConnectionString,sinkOptions,columnOptions:columnOptions).CreateLogger();
            Logger = seriLogConfig;
        }
    }
}
