using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Serilog.ConfigurationModel
{
    public class MsSqlConfiguration
    {

        public string ConnectionString { get; set; }
        public string TableName { get; set; }
        public bool AutoCreateSqlTable { get; set; }

        public MsSqlConfiguration(string table, bool autoCreateSqlTable, string connectionString)
        {
            TableName = table;
            AutoCreateSqlTable = autoCreateSqlTable;
            ConnectionString = connectionString;
        }
        public MsSqlConfiguration()
        {
            TableName = string.Empty;
            ConnectionString= string.Empty;
        }
    }
}
