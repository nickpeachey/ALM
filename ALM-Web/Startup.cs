using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALM_Web.Startup))]
namespace ALM_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
