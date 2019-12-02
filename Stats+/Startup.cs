using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stats_.Startup))]
namespace Stats_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
