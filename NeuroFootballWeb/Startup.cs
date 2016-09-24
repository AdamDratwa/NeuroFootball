using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeuroFootballWeb.Startup))]
namespace NeuroFootballWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
