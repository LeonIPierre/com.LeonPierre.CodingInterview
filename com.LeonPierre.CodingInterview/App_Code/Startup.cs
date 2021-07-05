using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(com.LeonPierre.CodingInterview.Startup))]
namespace com.LeonPierre.CodingInterview
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
