using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class Employee
    {
        public EmployeeModel EmployeeModel { get; set; }
        public ExperienceModel ExperienceModel { get; set; }
    }
    public class EmployeeModel
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Employee Name must be between 2-25 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Father Name must be between 2-25 characters")]
        public string FatherHusbandName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "DOB")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "BirthPlace")]
        public string BirthPlace { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "CNIC")]
        public string CNIC { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "MaritialStatus")]
        public string MaritialStatus { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Height")]
        public string Height { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "BloodGroup")]
        public string BloodGroup { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "IdentificationMark")]
        public string IdentificationMark { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Religion")]
        public string Religion { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Qualification")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Joining_Date")]
        public string Joining_Date { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        
        [Required(ErrorMessage = "*")]
        [Display(Name = "SectionId")]
        public string SectionId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Person_Contat_Email")]
        public string Person_Contat_Email { get; set; }
        [DataType(DataType.PhoneNumber), Required(ErrorMessage = "*")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Enter appropiate length of contact number")]
        [Display(Name = "Contat Number (0300xxxxxxx)")]
        public string Contact_Number { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "TemporaryAddress")]
        public string TemporaryAddress { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "PerminantAddress")]
        public string PerminantAddress { get; set; }
        
        [Required(ErrorMessage = "*")]
        [Display(Name = "Is_terminated")]
        public string Is_terminated { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "TerminatingDate")]
        public string TerminatingDate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Reason")]
        public string Reason { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Note")]
        public string Note { get; set; }
        public int OfficeID { get; set; }
        public int OrganizationID { get; set; }
        public int EmpID { get; set; }
        public ExperienceModel[] BomItems { get; set; }
    }
    public class ExperienceModel
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Position ")]
        public string Position { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "OrganizationName")]
        public string OrganizationName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "FromDate")]
        public string FromDate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "ToDate")]
        public string ToDate { get; set; }
        //public Employee[] BomItems { get; set; }

    }
}