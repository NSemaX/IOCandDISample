using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample.IOCLogging
{
    public class LoggingDIviaServiceLocator
    {
        private ILogging _logging = null;
        EventLocator el = new EventLocator();

        public LoggingDIviaServiceLocator(int index)
        {
            this._logging = el.LocateEvent(index);
        }
        public void Log()
        {
            this._logging.Log();
        }

        class EventLocator
        {
            public ILogging LocateEvent(int index)
            {
                if (index == 1)
                    return new DBLogging();
                else if (index == 2)
                    return new FileLogging();
                else
                    return null;
            }
        }
    }
}
