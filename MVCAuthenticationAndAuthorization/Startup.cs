using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuthenticationAndAuthorization.Startup))]
namespace MVCAuthenticationAndAuthorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
