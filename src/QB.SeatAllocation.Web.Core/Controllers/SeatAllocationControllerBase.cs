using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QB.SeatAllocation.Controllers
{
    public abstract class SeatAllocationControllerBase: AbpController
    {
        protected SeatAllocationControllerBase()
        {
            LocalizationSourceName = SeatAllocationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
