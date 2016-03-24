using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheCookieJar.Startup))]
namespace TheCookieJar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
