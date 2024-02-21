using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QB.SeatAllocation.EntityFrameworkCore
{
    public static class SeatAllocationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SeatAllocationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SeatAllocationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
