using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample.IOCLogging
{
    public class LoggingDIviaMethod
    {
        private ILogging _logging;
        public void GetEvent(ILogging myevent)
        {
            this._logging = myevent;
        }

        public void Log()
        {
            this._logging.Log();
        }
    }
}
