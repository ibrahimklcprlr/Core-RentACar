using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Logging
{
    public class LogDetailWithException:LogDetail
    {
       public string ExceptionMessage { get; set; }
        public LogDetailWithException()
        {
            ExceptionMessage = string.Empty;
        }
        public LogDetailWithException(string fullname, string methodname, string user, List<LogParameter> logParameters ,string exceptionmessage):base(fullname, methodname, user, logParameters) 
        {
            ExceptionMessage = exceptionmessage;
        }
    }
}
