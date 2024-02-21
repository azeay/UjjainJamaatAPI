using Abp.Application.Services.Dto;
using QB.SeatAllocation.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QB.SeatAllocation.Models;

namespace QB.SeatAllocation.SeatReservations.DTOs
{
    public class SeatReservationDto:EntityDto
    {
        public string SeatNumber { get; set; }
        public string Status { get; set; }
        public string SystemAddress { get; set; }
        public long ITS { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MiqaatFloorId { get; set; }
        public MiqaatFloor MiqaatFloor { get; set; }
    }
}
