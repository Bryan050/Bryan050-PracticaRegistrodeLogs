using log4net.Config;
using System.Reflection;

namespace log4net.console
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            
            Console.WriteLine("Hello, World!");

            log.Info("Esto es Info");
            log.Error("Esto es Error");
            log.Warn("Esto es Advertencia");

            Console.WriteLine();
        }
    }
}