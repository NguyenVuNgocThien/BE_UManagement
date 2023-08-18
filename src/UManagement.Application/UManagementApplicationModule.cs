using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UManagement.Authorization;

namespace UManagement
{
    [DependsOn(
        typeof(UManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
