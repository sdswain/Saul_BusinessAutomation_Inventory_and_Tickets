using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS_407_Inventory.Startup))]
namespace CIS_407_Inventory
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
