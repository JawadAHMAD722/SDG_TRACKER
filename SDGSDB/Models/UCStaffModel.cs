using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCStaffModel
    {
        public int UC_Concil_StaffId { get; set; }
        [Required]
        [Display(Name = "UC Staff Category")]
        public string UC_Staff_Category { get; set; }
        [Required]
        [Display(Name = "US Staff First Name")]
        public string US_StaffFirstName { get; set; }
        [Required]
        [Display(Name = "UC Staff Last Name")]
        public string UC_StaffLastName { get; set; }


        [Required]
        [Display(Name = "UC Staff Father Name")]
        public string FatherName { get; set; }
        [Required]
        [Display(Name = "UC Staff CNIC")]
        public string CNIC { get; set; }
        [Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DOB { get; set; }
        [Required]
        [Display(Name = "UC Staff BirthPlace")]
        public string BirthPlace { get; set; }
        [Required]
        [Display(Name = "UC Staff Gender")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "UC Staff Religion")]
        public string Religion { get; set; }
        [Required]
        [Display(Name = "UC Staff Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "UC Staff Educated")]
        public bool Educated { get; set; }
        [Required]
        [Display(Name = "UC Staff LastDegree")]
        public string LastDegree { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Starting Term")]
        public string StartingTerm { get; set; }
        [Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ending Term")]
        public string EndingTerm { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Contact Number)")]
        public string ContactNumber { get; set; }
        [Required]
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }
        [Required]
        [Display(Name = "Office Address")]
        public string OfficeAddress { get; set; }

    }
}