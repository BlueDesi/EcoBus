using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nortur.Startup))]
namespace Nortur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
