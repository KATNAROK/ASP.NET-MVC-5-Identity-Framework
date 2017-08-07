using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityFrameworkExample.Startup))]
namespace IdentityFrameworkExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
