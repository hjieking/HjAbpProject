using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HjAbpProject.MultiTenancy.Dto;

namespace HjAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

