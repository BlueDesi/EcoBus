using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Micros.Startup))]
namespace Micros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
