using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguimientoEgresados.Startup))]
namespace SeguimientoEgresados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
