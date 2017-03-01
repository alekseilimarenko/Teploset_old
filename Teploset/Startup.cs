using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teploset.Startup))]
namespace Teploset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}