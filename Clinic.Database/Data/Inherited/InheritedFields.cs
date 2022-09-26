﻿using System.ComponentModel.DataAnnotations;

namespace Clinic.Database.Data.Inherited
{
    public class InheritedFields
    {
        [Display(Name = "Who added")]
        public string WhoAdded { get; set; } = string.Empty;

        [Display(Name = "When added")]
        public DateTime WhenAdded { get; set; }

        [Display(Name = "Who modified")]
        public string WhoModified { get; set; } = string.Empty;

        [Display(Name = "When modified")]
        public DateTime? WhenModified { get; set; }

        [Display(Name = "Who removed")]
        public string WhoRemoved { get; set; } = string.Empty;

        [Display(Name = "When removed")]
        public DateTime? WhenRemoved { get; set; }

        [Display(Name = "Is Active")]
        public bool? IsActive { get; set; }
    }
}