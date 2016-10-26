using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrosWeb.Startup))]
namespace CrosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
