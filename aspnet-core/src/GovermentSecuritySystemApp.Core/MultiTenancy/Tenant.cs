using Abp.MultiTenancy;
using GovermentSecuritySystemApp.Authorization.Users;

namespace GovermentSecuritySystemApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
