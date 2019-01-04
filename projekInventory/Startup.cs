using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekInventory.Startup))]
namespace projekInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
