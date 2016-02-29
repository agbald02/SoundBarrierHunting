using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundBarrierHunting.WebUI.Startup))]
namespace SoundBarrierHunting.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
