using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QB.SeatAllocation.EntityFrameworkCore;
using QB.SeatAllocation.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QB.SeatAllocation.Web.Tests
{
    [DependsOn(
        typeof(SeatAllocationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SeatAllocationWebTestModule : AbpModule
    {
        public SeatAllocationWebTestModule(SeatAllocationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SeatAllocationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SeatAllocationWebMvcModule).Assembly);
        }
    }
}