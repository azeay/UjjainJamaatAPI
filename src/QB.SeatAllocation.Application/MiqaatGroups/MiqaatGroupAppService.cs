using Abp.Application.Services;
using Abp.Domain.Repositories;
using QB.SeatAllocation.MiqaatGroups.MiqaatGroupsDto;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.MiqaatGroups
{
    public class MiqaatGroupAppService : AsyncCrudAppService<MiqaatGroup, MiqaatGroupDto, int, PagedMiqaatGroupResultRequestDto, MiqaatGroupDto, MiqaatGroupDto>
    {
        private readonly IRepository<MiqaatGroup> _miqaatGroupsRepository;
        public MiqaatGroupAppService(IRepository<MiqaatGroup> repository) : base(repository)
        {
            _miqaatGroupsRepository = repository;
        }
    }
}
