using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab8_LINQwithASP.NET.Startup))]
namespace Lab8_LINQwithASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
