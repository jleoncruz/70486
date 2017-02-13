using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalUsers.Startup))]
namespace LocalUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
