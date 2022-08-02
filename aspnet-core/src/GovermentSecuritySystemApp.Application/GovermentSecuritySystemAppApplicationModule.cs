using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GovermentSecuritySystemApp.Authorization;

namespace GovermentSecuritySystemApp
{
    [DependsOn(
        typeof(GovermentSecuritySystemAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GovermentSecuritySystemAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GovermentSecuritySystemAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GovermentSecuritySystemAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
