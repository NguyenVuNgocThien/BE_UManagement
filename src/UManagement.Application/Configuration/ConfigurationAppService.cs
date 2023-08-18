using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using UManagement.Configuration.Dto;

namespace UManagement.Configuration
{
    public class ConfigurationAppService : UManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
