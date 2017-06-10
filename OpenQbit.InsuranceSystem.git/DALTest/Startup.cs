using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DALTest.Startup))]
namespace DALTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
