using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clPractice1.Startup))]
namespace clPractice1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
