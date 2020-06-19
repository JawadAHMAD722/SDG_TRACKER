using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCInitialRegistration
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Province")]
        public string ProvinceId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Division")]
        public string DivisionId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "District")]
        public string DistrictId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Tehsil")]
        public string Tehsil_Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Company name must be between 2-50 characters")]
        [Display(Name = "Union Council Name")]
        public string Organization_Name { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Focal Person Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="*")]
        [Display(Name="Contact Number (9231xxxxxxx)")]
        [StringLength(12,MinimumLength =11,ErrorMessage ="Enter appropiate length of contact number")]
        public string Contact_Number { get; set; }

        [Required(ErrorMessage = "*")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email_Id { get; set; }
        [Display(Name = "Additional Comments")]
        public string Additional_Comments { get; set; }
    }
}