using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuieroPizza2._0.Startup))]
namespace QuieroPizza2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
