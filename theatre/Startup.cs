using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theatre.Startup))]
namespace theatre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
