using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APP1.Startup))]
namespace APP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
