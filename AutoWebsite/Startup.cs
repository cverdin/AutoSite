using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoWebsite.Startup))]
namespace AutoWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
