using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneCityProject.Startup))]
namespace OneCityProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
