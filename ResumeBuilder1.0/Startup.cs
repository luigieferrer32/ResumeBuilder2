using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeBuilder1._0.Startup))]
namespace ResumeBuilder1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
