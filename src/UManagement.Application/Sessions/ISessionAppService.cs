using System.Threading.Tasks;
using Abp.Application.Services;
using UManagement.Sessions.Dto;

namespace UManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
