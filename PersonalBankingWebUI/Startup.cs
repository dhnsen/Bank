using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalBankingWebUI.Startup))]
namespace PersonalBankingWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
