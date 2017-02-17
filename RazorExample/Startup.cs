using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorExample.Startup))]
namespace RazorExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
