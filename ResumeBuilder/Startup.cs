using Owin;
using ResumeBuilder.App_Start;

namespace ResumeBuilder
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SecurityConfig.Configure(app);
            WebApiConfig.Configure(app);
        }
    }
}