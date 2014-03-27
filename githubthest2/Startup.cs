using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubthest2.Startup))]
namespace githubthest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
