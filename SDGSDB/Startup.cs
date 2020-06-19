using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("SDGSDB",typeof(SDGSDB.Startup))]
namespace SDGSDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
