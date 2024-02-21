using Abp.Application.Services;
using QB.SeatAllocation.Miqaats.DTOs;
using QB.SeatAllocation.Miqaats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QB.SeatAllocation.Models;
using Abp.Domain.Repositories;

namespace QB.SeatAllocation.Miqaats
{
    public class MiqaatAppService : AsyncCrudAppService<Miqaat, MiqaatDto, int, PagedMiqaatResultRequestDto, MiqaatDto, MiqaatDto>
    {
        private readonly IRepository<Miqaat> _miqaatsRepository;
        public MiqaatAppService(Abp.Domain.Repositories.IRepository<Miqaat> repository) : base(repository)
        {
            _miqaatsRepository = repository;
        }
    }
}
