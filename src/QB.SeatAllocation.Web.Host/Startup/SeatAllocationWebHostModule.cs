using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QB.SeatAllocation.Configuration;

namespace QB.SeatAllocation.Web.Host.Startup
{
    [DependsOn(
       typeof(SeatAllocationWebCoreModule))]
    public class SeatAllocationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SeatAllocationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SeatAllocationWebHostModule).GetAssembly());
        }
    }
}
