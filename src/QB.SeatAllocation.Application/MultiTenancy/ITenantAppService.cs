using Abp.Application.Services;
using QB.SeatAllocation.MultiTenancy.Dto;

namespace QB.SeatAllocation.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

