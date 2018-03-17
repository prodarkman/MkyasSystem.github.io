using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MkyasSystem.Startup))]
namespace MkyasSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
