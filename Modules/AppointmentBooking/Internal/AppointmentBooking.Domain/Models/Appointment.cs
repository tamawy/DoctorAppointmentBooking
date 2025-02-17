using AppointmentBooking.Domain.Models;
using AppointmentBooking.Shared.Events;


public class Appointment
{
    public Guid Id { get; set; }
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; } = default!;

    public DateTime? ReservedAt { get; set; } = DateTime.Now;
    // Navigation properties
    public Patient? Patient { get; set; }

    // Domain events
    private static readonly List<IAppointmentBookingEvent> _domainEvents = new();
    public IList<IAppointmentBookingEvent> DomainEvents => _domainEvents.AsReadOnly();

    private Appointment()
    {
    }

    private Appointment(Guid slotId, Guid patientId, string patientName, DateTime? reservedAt)
    {
        Id = Guid.NewGuid();
        SlotId = slotId;
        PatientId = patientId;
        PatientName = patientName;
        ReservedAt = reservedAt ?? DateTime.Now;
        // Add any validations 
    }

    // Factory method
    public static Appointment Book(Guid slotId, Guid patientId, string patientName, string doctorName, DateTime? reservedAt)
    {
        var appointment = new Appointment(slotId, patientId, patientName, reservedAt);
        // Add event to the DomainEvents
        var domainEvent = new AppointmentBookingEvent(patientName, doctorName, appointment.ReservedAt);
        Subscribe(domainEvent);
        return appointment;
    }

    private static void Subscribe(IAppointmentBookingEvent appointmentEvent) => _domainEvents.Add(appointmentEvent);
}

