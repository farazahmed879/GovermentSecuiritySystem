using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using GovermentSecuritySystemApp.Authorization.Roles;
using GovermentSecuritySystemApp.Authorization.Users;
using GovermentSecuritySystemApp.Configuration;
using GovermentSecuritySystemApp.Localization;
using GovermentSecuritySystemApp.MultiTenancy;
using GovermentSecuritySystemApp.Timing;

namespace GovermentSecuritySystemApp
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class GovermentSecuritySystemAppCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            GovermentSecuritySystemAppLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = GovermentSecuritySystemAppConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GovermentSecuritySystemAppCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
