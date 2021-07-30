using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentInfo.Startup))]
namespace StudentInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
