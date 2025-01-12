using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcoBus.Startup))]
namespace EcoBus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
