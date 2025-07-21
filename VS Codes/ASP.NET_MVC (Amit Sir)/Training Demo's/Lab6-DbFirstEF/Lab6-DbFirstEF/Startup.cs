using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab6_DbFirstEF.Startup))]
namespace Lab6_DbFirstEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
