using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppRad2016Week6.Startup))]
namespace ppRad2016Week6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
