using Owin;
using Nancy.Owin;

namespace BasicHTTPServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
