using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bullvy.Startup))]
namespace Bullvy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
