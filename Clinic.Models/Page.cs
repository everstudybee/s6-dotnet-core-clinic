using Clinic.Models.Inherited;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Page : InheritedFields
    {
        [Key]
        [Column(Order = 0)]
        public int PageId { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Write page anchor text")]
        [MaxLength(20, ErrorMessage = "The page anchor text should contain max. 20 characters")]
        [Display(Name = "Page Anchor Text")]
        public string PageAnchorText { get; set; } = String.Empty;

        [Column(Order = 2)]
        [Required(ErrorMessage = "Write page link")]
        [MaxLength(20, ErrorMessage = "The link should contain max. 20 characters and start with \"/\"")]
        [Display(Name = "Page Link")]
        public string PageLink { get; set; } = String.Empty;

        [Column(Order = 3)]
        [Required(ErrorMessage = "Set the page link position")]
        [Display(Name = "Page Link Positon")]
        public int PageLinkPosition { get; set; }
    }
}
