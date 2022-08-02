using Abp.Application.Services;
using GovermentSecuritySystemApp.MultiTenancy.Dto;

namespace GovermentSecuritySystemApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

