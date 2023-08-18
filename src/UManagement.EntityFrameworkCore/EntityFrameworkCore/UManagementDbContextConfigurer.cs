using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UManagement.EntityFrameworkCore
{
    public static class UManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
