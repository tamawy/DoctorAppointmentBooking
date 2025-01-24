using DoctorAvailability.Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
