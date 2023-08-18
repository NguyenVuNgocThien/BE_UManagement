using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UManagement.Configuration;

namespace UManagement.Web.Host.Startup
{
    [DependsOn(
       typeof(UManagementWebCoreModule))]
    public class UManagementWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UManagementWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UManagementWebHostModule).GetAssembly());
        }
    }
}
