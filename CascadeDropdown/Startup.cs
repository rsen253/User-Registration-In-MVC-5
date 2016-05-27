using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CascadeDropdown.Startup))]
namespace CascadeDropdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
