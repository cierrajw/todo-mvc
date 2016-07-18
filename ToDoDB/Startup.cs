using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoDB.Startup))]
namespace ToDoDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
