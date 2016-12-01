using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kent_demo.Startup))]
namespace kent_demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
