using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreativeFactory.Startup))]
namespace CreativeFactory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
