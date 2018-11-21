using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DienmayQT.Startup))]
namespace DienmayQT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
