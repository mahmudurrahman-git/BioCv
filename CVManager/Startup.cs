using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVManager.Startup))]
namespace CVManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
