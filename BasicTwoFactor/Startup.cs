using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicTwoFactor.Startup))]
namespace BasicTwoFactor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
