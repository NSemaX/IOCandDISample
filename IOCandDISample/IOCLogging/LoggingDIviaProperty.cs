using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample.IOCLogging
{
    public class LoggingDIviaProperty
    {
        private ILogging _logging;
        public ILogging MyEvent
        {
            set
            {
                _logging = value;
            }
        }


        public void Log()
        {
            this._logging.Log();
        }
    }
}
