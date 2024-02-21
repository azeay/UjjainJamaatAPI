using Abp.Application.Services.Dto;

namespace QB.SeatAllocation.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

