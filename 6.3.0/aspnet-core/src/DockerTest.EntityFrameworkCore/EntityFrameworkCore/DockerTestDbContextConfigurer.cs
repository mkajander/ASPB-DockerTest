using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.EntityFrameworkCore
{
    public static class DockerTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DockerTestDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DockerTestDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
