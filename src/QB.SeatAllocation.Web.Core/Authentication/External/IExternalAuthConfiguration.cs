using System.Collections.Generic;

namespace QB.SeatAllocation.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
