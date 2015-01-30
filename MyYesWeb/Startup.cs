using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyYesWeb.Startup))]
namespace MyYesWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
