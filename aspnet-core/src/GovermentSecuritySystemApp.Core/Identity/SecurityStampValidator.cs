using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using GovermentSecuritySystemApp.Authorization.Roles;
using GovermentSecuritySystemApp.Authorization.Users;
using GovermentSecuritySystemApp.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace GovermentSecuritySystemApp.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
