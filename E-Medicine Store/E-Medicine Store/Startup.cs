using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Medicine_Store.Startup))]
namespace E_Medicine_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
