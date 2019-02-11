using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quieropizza.Startup))]
namespace quieropizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
