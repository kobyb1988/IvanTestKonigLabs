using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex2__.Startup))]
namespace ex2__
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
