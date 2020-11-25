using System;
using Log4NetCore;
using log4net;
using log4net.Config;
using System.Reflection;
using System.IO;

namespace Log4NetCore
{

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            try
            {

                var repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

                var fileInfo = new FileInfo(@"log4net.config");

                log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

                log.Info("test");

                Console.WriteLine("press any key");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
        }
    }
}
