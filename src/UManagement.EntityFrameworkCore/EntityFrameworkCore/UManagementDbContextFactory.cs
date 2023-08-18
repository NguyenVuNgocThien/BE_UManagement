using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UManagement.Configuration;
using UManagement.Web;

namespace UManagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UManagementDbContextFactory : IDesignTimeDbContextFactory<UManagementDbContext>
    {
        public UManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UManagementConsts.ConnectionStringName));

            return new UManagementDbContext(builder.Options);
        }
    }
}
