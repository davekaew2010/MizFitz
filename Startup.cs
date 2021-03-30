using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MizFitzCapstone.Startup))]
namespace MizFitzCapstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
