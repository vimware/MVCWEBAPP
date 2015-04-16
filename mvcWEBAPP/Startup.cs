using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcWEBAPP.Startup))]
namespace mvcWEBAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
