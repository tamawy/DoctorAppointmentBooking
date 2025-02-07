
using DoctorAvailability.Internal.EF;
using DoctorAvailability.Internal.Models;

namespace DoctorAvailability.Internal.DAL
{
    public class DoctorsDal(ApplicationDbContext context)
    {
        /// <summary>
        /// Get all doctors in the DB
        /// </summary>
        /// <returns>List of doctors</returns>
        public List<Doctor> GetDoctors()
        {
            return [.. context.Doctors];
        }

        /// <summary>
        /// Add new doctor to the DB
        /// </summary>
        /// <param name="doctor">instance of Doctor model</param>
        public void AddDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            context.SaveChanges();
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
