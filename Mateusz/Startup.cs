using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mateusz.Startup))]
namespace Mateusz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
