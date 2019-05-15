using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HjAbpProject.Configuration;

namespace HjAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(HjAbpProjectWebCoreModule))]
    public class HjAbpProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HjAbpProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HjAbpProjectWebHostModule).GetAssembly());
        }
    }
}
