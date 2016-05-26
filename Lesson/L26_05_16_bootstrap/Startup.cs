using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L26_05_16_bootstrap.Startup))]
namespace L26_05_16_bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
