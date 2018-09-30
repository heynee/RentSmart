using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentSmart.Startup))]
namespace RentSmart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
