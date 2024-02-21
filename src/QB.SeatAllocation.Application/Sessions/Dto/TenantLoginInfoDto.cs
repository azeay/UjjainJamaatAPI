using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using QB.SeatAllocation.MultiTenancy;

namespace QB.SeatAllocation.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
