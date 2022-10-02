using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Entities.Models;

public class Appointment
{
    [Key]
    [Column(Order = 0)]
    public int ApointmentId { get; set; }

    [Column(Order = 1)]
    [Required(ErrorMessage = "Write patient name")]
    public string Patient { get; set; } = string.Empty;

    [Column(Order = 2)]
    public int DoctorId { get; set; }

    [Column(Order = 3)]
    public Doctor? Doctor { get; set; }

    [Column(Order = 4)]
    public string SessionId { get; set; } = string.Empty;

    [Column(Order = 5)]
    [Required(ErrorMessage = "Choose appointment date")]
    public DateTime AppointmentDate { get; set; }

    [Column(Order = 6)]
    public DateTime CreateDate { get; set; }
}
