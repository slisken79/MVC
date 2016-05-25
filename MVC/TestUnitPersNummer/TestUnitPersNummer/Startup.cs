using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUnitPersNummer.Startup))]
namespace TestUnitPersNummer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
