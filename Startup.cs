using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiTest.Startup))]
namespace MultiTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
