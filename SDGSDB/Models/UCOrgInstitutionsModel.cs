using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCOrgInstitutionsModel
    {
        public int UC_OrganizationId { get; set; }
        public string Sector_Name { get; set; }
        public string Category_Name { get; set; }
        [Required]
        [Display(Name = "UC Sector")]
        public int Sector_Id { get; set; }
        [Required]
        [Display(Name = "Sector Category")]
        public int Sector_Category_Id { get; set; }
        
        [ Required]
        [Display(Name = "Organization Name")]
        public string Organization { get; set; }
        [Required]
        [Display(Name = "Organization Nature")]
        public string OrganizationNature { get; set; }
        [Required]
        [Display(Name = "Locality")]
        public string Locality { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Contact Person Name")]
        public string ContactPersonName { get; set; }
        [Required]
        [Display(Name = "Contact Number (9231xxxxxxx)")]
        [StringLength(12, MinimumLength = 11, ErrorMessage = "Enter appropiate length of contact number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

    }
}