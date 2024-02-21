using System.Threading.Tasks;
using Abp.Application.Services;
using QB.SeatAllocation.Sessions.Dto;

namespace QB.SeatAllocation.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
