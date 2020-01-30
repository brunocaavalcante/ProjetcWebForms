using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsApplication.Startup))]
namespace WebFormsApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
