using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoluntaryHousing.Startup))]
namespace VoluntaryHousing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
