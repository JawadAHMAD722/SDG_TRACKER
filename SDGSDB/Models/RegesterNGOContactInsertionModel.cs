using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class Cmb_Types
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class NGOCompoundModel
    {
       
        public RegesterNGOContactInsertionModel ContactModel { get; set; }
        public RegesterNGOEmailModel EmailModel { get; set; }
    }
    public class RegesterNGOContactInsertionModel
    {
        [Required(ErrorMessage = "*")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{1,}")]
        [StringLength(12, MinimumLength = 11, ErrorMessage = "Enter appropiate length of contact number")]
        [Display(Name = "Contat Number (9231xxxxxxx)")]
        public string Contact_Number { get; set; }
        [Required(ErrorMessage = "*")]
        [RegularExpression("[0-9]{1,}")]
        [Display(Name = "*")]
        public string Fax { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Website_URL { get; set; }
    }

    public class RegesterNGOEmailModel
    {
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        [Display(Name = "*")]
        public string Email_Id { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "*")]
        public string Email_Type { get; set; }
    }

    
}