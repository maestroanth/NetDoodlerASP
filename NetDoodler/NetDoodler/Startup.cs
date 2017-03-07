using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetDoodler.Startup))]
namespace NetDoodler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
