using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(care4u1guia.Startup))]
namespace care4u1guia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
