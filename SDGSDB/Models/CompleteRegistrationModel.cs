using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class drpRegisterationAuthority
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class drpCompanyCategory
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class SDGSRegistration
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class SDGSChkModel
    {
        public List<string> STRMSelected { get; set; }
    }
    public class CompleteRegistrationModel
    {
        [Required]
        [Display(Name = "HeadOffice Name")]
        public string HeadOffice_Name { get; set; }
        [Required]
        [Display(Name = "Registeration Authority")]
        public string Registeration_Authority { get; set; }
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Registeration Date")]
        public string Registeration_Date { get; set; }
        [ Required]
        [Display(Name = "License No.")]
        public string LicenseNo { get; set; }
        [Required]
        [Display(Name = "Company Category")]
        public string CompanyCategory { get; set; }
        [Required]
        [Display(Name = "Person Name")]
        public string Person_Contact_Name { get; set; }
        [Required]
        [Display(Name = "Designagion")]
        public string Person_Contact_Title { get; set; }
        [DataType(DataType.PhoneNumber),Required]
        [StringLength(12, MinimumLength = 11, ErrorMessage = "Enter appropiate length of contact number")]
        [Display(Name = "Contat Number (9231xxxxxxx)")]
        public string Person_Contat_Number { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Person_Contat_Email { get; set; }
        [Required]
        [Display(Name = "Business Type")]
        public string BusinessType { get; set; }
        [Required]
        [Display(Name = "Planned Activities")]
        public string Planned_Activities { get; set; }
        [Required]
        [Display(Name = "Additional Comments")]
        public string Additional_Comments { get; set; }
        [Required]
        [Display(Name = "Logo")]
        public string Logo_Image { get; set; }
        [Required]
        [Display(Name = "Province")]
        public int Province_Id { get; set; }
        [Required]
        [Display(Name = "Tehsils")]
        public int Tehsil_Id { get; set; }
        [Required]
        [Display(Name = "Union Councils")]
        public int UC_Id { get; set; }
        [Required]
        [Display(Name = "Division")]
        public int Division_Id { get; set; }
        [Required]
        [Display(Name = "District")]
        public int District_Id { get; set; }
        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "House")]
        public string House { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }
        public string[] SDGSLIST { get; set; }
        public string[] SDGSINDLIST { get; set; }
    }
}