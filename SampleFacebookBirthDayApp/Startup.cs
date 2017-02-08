using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleFacebookBirthDayApp.Startup))]
namespace SampleFacebookBirthDayApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
