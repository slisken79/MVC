using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTentaTest.Startup))]
namespace MVCTentaTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
