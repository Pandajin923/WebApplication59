using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication59.Startup))]
namespace WebApplication59
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
