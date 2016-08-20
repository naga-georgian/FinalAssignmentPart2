using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalAssignmentPart2.Startup))]
namespace FinalAssignmentPart2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
