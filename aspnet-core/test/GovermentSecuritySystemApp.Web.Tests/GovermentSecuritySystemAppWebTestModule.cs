using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GovermentSecuritySystemApp.EntityFrameworkCore;
using GovermentSecuritySystemApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GovermentSecuritySystemApp.Web.Tests
{
    [DependsOn(
        typeof(GovermentSecuritySystemAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GovermentSecuritySystemAppWebTestModule : AbpModule
    {
        public GovermentSecuritySystemAppWebTestModule(GovermentSecuritySystemAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GovermentSecuritySystemAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GovermentSecuritySystemAppWebMvcModule).Assembly);
        }
    }
}