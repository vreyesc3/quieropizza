using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuieroPizza3.Startup))]
namespace QuieroPizza3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
