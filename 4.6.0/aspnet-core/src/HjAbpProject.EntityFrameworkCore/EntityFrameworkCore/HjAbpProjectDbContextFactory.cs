using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HjAbpProject.Configuration;
using HjAbpProject.Web;

namespace HjAbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HjAbpProjectDbContextFactory : IDesignTimeDbContextFactory<HjAbpProjectDbContext>
    {
        public HjAbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HjAbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HjAbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HjAbpProjectConsts.ConnectionStringName));

            return new HjAbpProjectDbContext(builder.Options);
        }
    }
}
