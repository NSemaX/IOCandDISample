using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample
{
   public class NonIOCDBLogging
    {
        public void Log()
        {
            Console.WriteLine("Logging to DB.");
        }
    }
}
