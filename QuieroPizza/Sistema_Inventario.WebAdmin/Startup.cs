using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema_Inventario.WebAdmin.Startup))]
namespace Sistema_Inventario.WebAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
