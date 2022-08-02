using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GovermentSecuritySystemApp.Configuration;
using GovermentSecuritySystemApp.EntityFrameworkCore;
using GovermentSecuritySystemApp.Migrator.DependencyInjection;

namespace GovermentSecuritySystemApp.Migrator
{
    [DependsOn(typeof(GovermentSecuritySystemAppEntityFrameworkModule))]
    public class GovermentSecuritySystemAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GovermentSecuritySystemAppMigratorModule(GovermentSecuritySystemAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GovermentSecuritySystemAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GovermentSecuritySystemAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GovermentSecuritySystemAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
