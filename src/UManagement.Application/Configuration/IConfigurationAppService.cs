using System.Threading.Tasks;
using UManagement.Configuration.Dto;

namespace UManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
