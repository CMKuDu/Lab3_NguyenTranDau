using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_NguyenTranDau.Startup))]
namespace Lab3_NguyenTranDau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
