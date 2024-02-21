using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QB.SeatAllocation.Configuration.Dto;

namespace QB.SeatAllocation.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SeatAllocationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
