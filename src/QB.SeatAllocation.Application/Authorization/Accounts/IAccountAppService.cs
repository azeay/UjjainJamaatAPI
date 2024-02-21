using System.Threading.Tasks;
using Abp.Application.Services;
using QB.SeatAllocation.Authorization.Accounts.Dto;

namespace QB.SeatAllocation.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
