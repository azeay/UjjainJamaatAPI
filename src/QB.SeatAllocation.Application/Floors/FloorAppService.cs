using Abp.Application.Services;
using Abp.Domain.Repositories;
using QB.SeatAllocation.Floors;
using QB.SeatAllocation.Floors.DTOs;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Floors
{
    public class FloorAppService : AsyncCrudAppService<Floor, FloorDto, int, PagedFloorResultRequestDto, FloorDto, FloorDto>
    {
        private readonly IRepository<Floor> _floorsRepository;
        public FloorAppService(IRepository<Floor> repository) : base(repository)
        {
            _floorsRepository = repository;
        }
    }
}
