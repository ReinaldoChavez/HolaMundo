using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaVisual.Startup))]
namespace PruebaVisual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
