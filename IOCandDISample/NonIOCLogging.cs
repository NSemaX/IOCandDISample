using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample
{
   public class NonIOCLogging
    {
        private NonIOCDBLogging _logging;
        public NonIOCLogging()
        {
            _logging = new NonIOCDBLogging();

        }

        public void Log()
        {
            _logging.Log();
        }
    }
}
