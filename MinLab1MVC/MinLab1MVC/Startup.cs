using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinLab1MVC.Startup))]
namespace MinLab1MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
