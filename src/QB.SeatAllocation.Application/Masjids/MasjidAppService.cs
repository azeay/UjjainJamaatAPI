using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using QB.SeatAllocation.Masjids.Dtos;
using QB.SeatAllocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Masjids
{
    public class MasjidAppService : AsyncCrudAppService<Masjid, MasjidDto, int, PagedMasjidResultRequestDto, MasjidDto, MasjidDto>
    {
        private readonly IRepository<Masjid> _masjidsRepository;
        public MasjidAppService(IRepository<Masjid> repository) : base(repository)
        {
            _masjidsRepository = repository;
        }

        [HttpGet]
        public async Task<int> CalculateSomething()
        {
            var a = _masjidsRepository.Count() + 1;
            return a;
        }

    }
}
