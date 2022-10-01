using Clinic.Models.Inherited;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Parameter : InheritedFields
    {
        [Key]
        [Column(Order = 0)]
        public int ParameterId { get; set; }

        [Column(Order = 1)]
        [Required]
        [MaxLength(20, ErrorMessage = "The field should contain max. 20 characters")]
        public string Code { get; set; } = String.Empty;

        [Column(Order = 2)]
        [Required]
        [MaxLength(30, ErrorMessage = "The field should contain max. 30 characters")]
        public string Name { get; set; } = String.Empty;

        [Column(Order = 3)]
        [Required]
        [MaxLength(200, ErrorMessage = "The field should contain max. 200 characters")]
        public string Content { get; set; } = String.Empty;
    }
}
