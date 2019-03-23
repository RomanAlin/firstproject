using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstProject.Startup))]
namespace FirstProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
