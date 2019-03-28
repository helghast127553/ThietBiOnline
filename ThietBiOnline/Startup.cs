using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThietBiOnline.Startup))]
namespace ThietBiOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
