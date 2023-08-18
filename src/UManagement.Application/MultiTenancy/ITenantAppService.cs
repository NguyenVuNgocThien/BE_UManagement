using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UManagement.MultiTenancy.Dto;

namespace UManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

