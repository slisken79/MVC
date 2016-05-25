using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTestUnit.Startup))]
namespace MvcTestUnit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
