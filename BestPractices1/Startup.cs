using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestPractices1.Startup))]
namespace BestPractices1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
