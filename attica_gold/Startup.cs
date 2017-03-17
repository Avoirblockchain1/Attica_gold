using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(attica_gold.Startup))]
namespace attica_gold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
