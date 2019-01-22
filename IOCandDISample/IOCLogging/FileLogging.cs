using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample.IOCLogging
{
    public class FileLogging :ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logging to file.");
        }
    }
}
