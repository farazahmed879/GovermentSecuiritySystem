using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GovermentSecuritySystemApp.Configuration;
using GovermentSecuritySystemApp.Web;

namespace GovermentSecuritySystemApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GovermentSecuritySystemAppDbContextFactory : IDesignTimeDbContextFactory<GovermentSecuritySystemAppDbContext>
    {
        public GovermentSecuritySystemAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GovermentSecuritySystemAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GovermentSecuritySystemAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GovermentSecuritySystemAppConsts.ConnectionStringName));

            return new GovermentSecuritySystemAppDbContext(builder.Options);
        }
    }
}
