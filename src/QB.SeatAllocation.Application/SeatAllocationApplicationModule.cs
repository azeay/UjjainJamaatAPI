using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QB.SeatAllocation.Authorization;
using QB.SeatAllocation.Floors.DTOs;
using QB.SeatAllocation.Masjids.Dtos;
using QB.SeatAllocation.MiqaatFloors.MiqaatFloorDtos;
using QB.SeatAllocation.MiqaatGroups.MiqaatGroupsDto;
using QB.SeatAllocation.Miqaats.DTOs;
using QB.SeatAllocation.Models;
using QB.SeatAllocation.SeatReservations.DTOs;

namespace QB.SeatAllocation
{
    [DependsOn(
        typeof(SeatAllocationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SeatAllocationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SeatAllocationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SeatAllocationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => { 
                    cfg.AddMaps(thisAssembly);
                    cfg.CreateMap<Masjid, MasjidDto>().ReverseMap();
                    cfg.CreateMap<Floor, FloorDto>().ReverseMap();
                    cfg.CreateMap<Miqaat,MiqaatDto>().ReverseMap();
                    cfg.CreateMap<MiqaatFloor, MiqaatFloorDto>().ReverseMap();
                    cfg.CreateMap<MiqaatGroup, MiqaatGroupDto>().ReverseMap();
                    cfg.CreateMap<SeatReservation, SeatReservationDto>().ReverseMap();
                }
            );
        }
    }
}
