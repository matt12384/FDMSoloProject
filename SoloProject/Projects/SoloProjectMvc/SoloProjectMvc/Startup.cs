using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoloProjectMvc.Startup))]
namespace SoloProjectMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
