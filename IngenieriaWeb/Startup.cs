using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IngenieriaWeb.Startup))]
namespace IngenieriaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
