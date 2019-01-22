using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample.IOCLogging
{
    public class Logging
    {
        private ILogging _logging;
        public Logging(ILogging ie)
        {
            _logging = ie;

        }

        public void Log()
        {
            this._logging.Log();
        }
    }
}
