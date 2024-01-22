using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Logging
{
    public class LogDetail
    {
        public string Fullname;
        public string Methodname { get; set; }
        public string User { get; set; }
        public List<LogParameter> Parameters { get; set; }
        public LogDetail()
        {
            Parameters = new List<LogParameter>();
            Fullname = string.Empty;
            Methodname = string.Empty;
            User = string.Empty;
        }
        public LogDetail(string fullname,string methodname,string user,List<LogParameter> logParameters)
        {
            Fullname=fullname;
            Methodname=methodname;
            User=user;
            Parameters = logParameters;
        }
    }
}
