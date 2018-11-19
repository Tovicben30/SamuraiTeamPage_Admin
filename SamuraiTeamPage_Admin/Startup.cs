using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamuraiTeamPage_Admin.Startup))]
namespace SamuraiTeamPage_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
