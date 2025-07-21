using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_10_ASP.NET_Identity_Google.Startup))]
namespace Lab_10_ASP.NET_Identity_Google
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
