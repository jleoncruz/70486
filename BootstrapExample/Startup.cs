using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapExample.Startup))]
namespace BootstrapExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
