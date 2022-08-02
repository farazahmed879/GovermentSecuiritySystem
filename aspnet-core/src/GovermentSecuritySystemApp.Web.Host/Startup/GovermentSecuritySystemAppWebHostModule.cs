using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GovermentSecuritySystemApp.Configuration;

namespace GovermentSecuritySystemApp.Web.Host.Startup
{
    [DependsOn(
       typeof(GovermentSecuritySystemAppWebCoreModule))]
    public class GovermentSecuritySystemAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GovermentSecuritySystemAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GovermentSecuritySystemAppWebHostModule).GetAssembly());
        }
    }
}
