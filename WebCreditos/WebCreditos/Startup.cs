using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCreditos.Startup))]
namespace WebCreditos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
