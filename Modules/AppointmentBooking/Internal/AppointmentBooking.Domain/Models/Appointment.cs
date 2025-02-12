﻿using AppointmentBooking.Domain.Models;


public class Appointment
{
    public Guid Id { get; set; }
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; } = default!;

    public DateTime? ReservedAt { get; set; } = DateTime.Now;
    // Navigation properties
    public Patient? Patient { get; set; }
    //public Slot? Slot { get; set; }
}

