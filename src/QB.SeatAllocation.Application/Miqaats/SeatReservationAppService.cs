using Abp.Application.Services;
using Abp.Domain.Repositories;
using QB.SeatAllocation.Models;
using QB.SeatAllocation.SeatReservations.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Miqaats
{
    public class SeatReservationAppService : AsyncCrudAppService<SeatReservation, SeatReservationDto, int, PagedSeatReservationResultRequestDto, SeatReservationDto, SeatReservationDto>
    {
        private readonly IRepository<SeatReservation> _seatReservationsRepository;
        public SeatReservationAppService(IRepository<SeatReservation> repository) : base(repository)
        {
            _seatReservationsRepository = repository;
        }
    }
}
