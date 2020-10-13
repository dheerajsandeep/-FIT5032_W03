using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w7demo.Startup))]
namespace w7demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
