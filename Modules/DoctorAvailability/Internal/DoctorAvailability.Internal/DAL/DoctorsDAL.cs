
using DoctorAvailability.Internal.EF;
using DoctorAvailability.Internal.Models;

namespace DoctorAvailability.Internal.DAL
{
    public class DoctorsDAL
    {
        public ApplicationDbContext _context;
        public DoctorsDAL(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Doctor> GetDoctors()
        {
            return [.. _context.Doctors];
        }
        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }
        public Guid GetCurrentDoctorId()
        {
            var id = GetDoctors().FirstOrDefault()?.Id;
            if (id == null)
            {
                var doctorId = Guid.NewGuid();
                AddDoctor(new Doctor()
                {
                    Name = "Dr. Ali Ahmed",
                    Id = doctorId
                });
                return doctorId;
            }
            return id.Value;
        }
    }
}
