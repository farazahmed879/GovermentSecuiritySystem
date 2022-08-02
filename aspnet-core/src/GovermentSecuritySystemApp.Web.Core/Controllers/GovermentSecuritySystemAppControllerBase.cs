using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GovermentSecuritySystemApp.Controllers
{
    public abstract class GovermentSecuritySystemAppControllerBase: AbpController
    {
        protected GovermentSecuritySystemAppControllerBase()
        {
            LocalizationSourceName = GovermentSecuritySystemAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
