using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(huinspector.Startup))]
namespace huinspector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
