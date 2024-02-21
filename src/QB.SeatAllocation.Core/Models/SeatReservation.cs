using Abp.Domain.Entities;
using QB.SeatAllocation.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QB.SeatAllocation.Models
{
    public class SeatReservation : Entity
    {
        public string SeatNumber { get; set; }
        public string Status { get; set; }
        public string SystemAddress { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? MuminId { get; set; }
        public User Mumin { get; set; }
        public int MiqaatFloorId { get; set; }
        public MiqaatFloor MiqaatFloor { get; set; }
        public int? CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
        public int? UpdatedByUserId { get; set; }
        public User UpdatedByUser { get; set; }
    }
}
