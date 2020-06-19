using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class RegesterOfficeContactModel
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Contact_Number { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Fax { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Website_URL { get; set; }
    }

    public class RegesterOfficeEmailModel
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Email_Id { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Email_Type { get; set; }
    }
}