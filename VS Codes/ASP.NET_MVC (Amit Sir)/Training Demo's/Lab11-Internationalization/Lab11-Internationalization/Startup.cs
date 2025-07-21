using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab11_Internationalization.Startup))]
namespace Lab11_Internationalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
