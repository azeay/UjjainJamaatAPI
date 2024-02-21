using System.Threading.Tasks;
using QB.SeatAllocation.Configuration.Dto;

namespace QB.SeatAllocation.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
