using IOCandDISample.IOCLogging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCandDISample
{
    class Program
    {
        static void Main(string[] args)
        {
            //non -ioc
            NonIOCLogging logmanager = new NonIOCLogging();
            logmanager.Log();


            //injection via constructor
            Logging logmanager_ioc = new Logging(new DBLogging());
            logmanager_ioc.Log();

            Logging logmanager_ioc1 = new Logging(new FileLogging());
            logmanager_ioc1.Log();

            //injection via property
            LoggingDIviaProperty logmanager_ioc2 = new LoggingDIviaProperty();
            logmanager_ioc2.MyEvent = new DBLogging();
            logmanager_ioc2.Log();

            //injection via method
            LoggingDIviaMethod logmanager_ioc3 = new LoggingDIviaMethod();
            logmanager_ioc3.GetEvent(new DBLogging());
            logmanager_ioc3.Log();

            //injection via service locator
            LoggingDIviaServiceLocator logmanager_ioc4 = new LoggingDIviaServiceLocator(1);
            logmanager_ioc4.Log();

            Console.ReadLine();
        }
    }
}
