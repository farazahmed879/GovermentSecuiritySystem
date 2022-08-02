using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GovermentSecuritySystemApp.EntityFrameworkCore
{
    public static class GovermentSecuritySystemAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GovermentSecuritySystemAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GovermentSecuritySystemAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
