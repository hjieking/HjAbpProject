using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HjAbpProject.EntityFrameworkCore
{
    public static class HjAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HjAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HjAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
