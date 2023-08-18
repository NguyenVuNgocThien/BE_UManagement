using System.Threading.Tasks;
using Abp.Application.Services;
using UManagement.Authorization.Accounts.Dto;

namespace UManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
