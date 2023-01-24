using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(log4net.mvc.Startup))]
namespace log4net.mvc
{
    public partial class Startup
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Configuration(IAppBuilder app)
        {
            log.Info("Se llamó al método Startup()");
            ConfigureAuth(app);
        }
    }
}
