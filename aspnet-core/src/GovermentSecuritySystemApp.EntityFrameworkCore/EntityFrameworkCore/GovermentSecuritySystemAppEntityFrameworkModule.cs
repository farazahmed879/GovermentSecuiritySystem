using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using GovermentSecuritySystemApp.EntityFrameworkCore.Seed;

namespace GovermentSecuritySystemApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(GovermentSecuritySystemAppCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class GovermentSecuritySystemAppEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<GovermentSecuritySystemAppDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        GovermentSecuritySystemAppDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        GovermentSecuritySystemAppDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GovermentSecuritySystemAppEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
