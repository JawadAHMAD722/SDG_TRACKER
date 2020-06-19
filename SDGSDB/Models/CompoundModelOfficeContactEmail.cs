using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SDGSDB.Models
{
    public class CompoundModelOfficeContactEmail
    {
        public class CompoundModel
        {
            public RegesterOfficeContactModel OfficeContactModel { get; set; }
            public RegesterOfficeEmailModel OfficeEmailModel { get; set; }
        }
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
            public string Email_Address_Id { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "*")]
            public string Email_Id { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "*")]
            public string Email_Type { get; set; }
        }
    }
}