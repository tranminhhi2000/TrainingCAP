using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapMedicial.Startup))]
namespace CapMedicial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
