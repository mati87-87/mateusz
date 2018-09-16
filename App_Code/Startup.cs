using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mateusz.Startup))]
namespace mateusz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
