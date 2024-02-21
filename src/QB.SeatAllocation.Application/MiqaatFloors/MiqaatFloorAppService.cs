using Abp.Application.Services;
using Abp.Domain.Repositories;
using QB.SeatAllocation.MiqaatFloors.MiqaatFloorDtos;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.MiqaatFloors
{
    public class MiqaatFloorAppService : AsyncCrudAppService<MiqaatFloor, MiqaatFloorDto, int, PagedMiqaatFloorResultRequestDto, MiqaatFloorDto, MiqaatFloorDto>
    {
        private readonly IRepository<MiqaatFloor> _miqaatFloorsRepository;
        public MiqaatFloorAppService(IRepository<MiqaatFloor> repository) : base(repository)
        {
            _miqaatFloorsRepository = repository;
        }
    }
}
