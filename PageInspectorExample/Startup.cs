using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageInspectorExample.Startup))]
namespace PageInspectorExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
