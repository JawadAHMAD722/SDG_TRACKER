using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class Organization
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Company name must be between 2-50 characters")]
        [Display(Name="Company Name")]
        public string Organization_Name { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name="Focal Person Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="*")]
        [Display(Name="Contact Number (9231xxxxxxx)")]
        [StringLength(12,MinimumLength =11,ErrorMessage ="Enter appropiate length of contact number")]
        public string Contact_Number { get; set; }

        [Required(ErrorMessage = "*")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email_Id { get; set; }

        
        public string Organization_Type_Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(225,MinimumLength =2,ErrorMessage ="Enter Type of business atleast 10 chracters")]
        [Display(Name="Business Type")]
        public string Type_of_business { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(225, MinimumLength = 2, ErrorMessage = "Enter Planed Activities atleast 10 chracters")]
        [Display(Name = "Planed Activities")]
        public string Planed_Activity { get; set; }


        [Display(Name = "Additional Comments")]
        public string Additional_Comments { get; set; }
    }
}