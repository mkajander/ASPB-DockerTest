using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DockerTest.Configuration;
using DockerTest.Web;

namespace DockerTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DockerTestDbContextFactory : IDesignTimeDbContextFactory<DockerTestDbContext>
    {
        public DockerTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DockerTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DockerTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DockerTestConsts.ConnectionStringName));

            return new DockerTestDbContext(builder.Options);
        }
    }
}
