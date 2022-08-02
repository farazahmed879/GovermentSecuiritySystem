using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GovermentSecuritySystemApp.Authorization.Roles;
using GovermentSecuritySystemApp.Authorization.Users;
using GovermentSecuritySystemApp.MultiTenancy;

namespace GovermentSecuritySystemApp.EntityFrameworkCore
{
    public class GovermentSecuritySystemAppDbContext : AbpZeroDbContext<Tenant, Role, User, GovermentSecuritySystemAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GovermentSecuritySystemAppDbContext(DbContextOptions<GovermentSecuritySystemAppDbContext> options)
            : base(options)
        {
        }
    }
}
