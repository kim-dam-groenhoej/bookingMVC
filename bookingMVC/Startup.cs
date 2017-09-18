using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bookingMVC.Startup))]
namespace bookingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
