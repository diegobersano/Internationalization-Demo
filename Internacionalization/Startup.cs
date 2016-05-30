using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internacionalization.Startup))]
namespace Internacionalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
