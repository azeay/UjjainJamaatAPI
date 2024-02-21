using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QB.SeatAllocation.Authorization.Roles;
using QB.SeatAllocation.Authorization.Users;
using QB.SeatAllocation.MultiTenancy;
using QB.SeatAllocation.Models;

namespace QB.SeatAllocation.EntityFrameworkCore
{
    public class SeatAllocationDbContext : AbpZeroDbContext<Tenant, Role, User, SeatAllocationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Masjid> Masjids { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Miqaat> Miqaats { get; set; }
        public DbSet<MiqaatFloor> MiqaatFloors { get; set; }

        public DbSet<MiqaatGroup> MiqaatGroups { get; set; }

        public DbSet<SeatReservation> SeatReservations { get; set; }
        public SeatAllocationDbContext(DbContextOptions<SeatAllocationDbContext> options)
            : base(options)
        {
        }
    }
}
