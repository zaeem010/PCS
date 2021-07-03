using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCS.Startup))]
namespace PCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
