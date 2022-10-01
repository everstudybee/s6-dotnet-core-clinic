using Clinic.DataAccess.Data.Inherited;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Database.Data
{
    public class Doctor : InheritedFields
    {
        [Key]
        [Column(Order = 0)]
        public int DoctorId { get; set; }

        [Column(Order = 1)]
        [Required]
        [MaxLength(40, ErrorMessage = "The field should contain max. 40 characters")]
        public string Name { get; set; } = String.Empty;

        [Column(Order = 2)]
        [Required]
        public string ImageSmall { get; set; } = String.Empty;

        [Column(Order = 3)]
        [Required]
        public string Image { get; set; } = String.Empty;

        [Column(Order = 4)]
        [Required]
        [MaxLength(30, ErrorMessage = "The field should contain max. 30 characters")]
        public string Specialty { get; set; } = String.Empty;

        [Column(Order = 5)]
        [Required]
        [MaxLength(30, ErrorMessage = "The field should contain max. 30 characters")]
        public string Experience { get; set; } = String.Empty;

        [Column(Order = 6)]
        [Required]
        [MaxLength(30, ErrorMessage = "The field should contain max. 30 characters")]
        public string Education { get; set; } = String.Empty;

        [Column(Order = 7)]
        [Required]
        [MaxLength(20, ErrorMessage = "The field should contain max. 20 characters")]
        public string Area { get; set; } = String.Empty;

        [Column(Order = 8)]
        [Required]
        [MaxLength(50, ErrorMessage = "The field should contain max. 50 characters")]
        public string Certifications { get; set; } = String.Empty;

        [Column(Order = 9)]
        [Required]
        [MaxLength(100, ErrorMessage = "The field should contain max. 100 characters")]
        [Display(Name = "Short Presentation")]
        public string ShortPresentation { get; set; } = String.Empty;

        [Column(Order = 10)]
        [Required]
        public string Biography { get; set; } = String.Empty;

        [Column(Order = 11)]
        [Required]
        [Display(Name = "Positon")]
        public int Position { get; set; }

        [Column(Order = 12)]
        [Display(Name = "Is Active")]
        public bool? IsHomePage { get; set; }
    }
}
