using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class ProjectCreationModel
    {
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Required]
        [Display(Name = "Project Category")]
        public int ProjectCategory { get; set; }
        [Required]
        [Display(Name = "Major Objectives")]
        public string Objectives { get; set; }
        [Required]
        [Display(Name = "Stakeholders")]
        public int StackHolderId { get; set; }
        [Required]
        [Display(Name = "Feasibility Report")]
        public string UploadfeasibilityReport { get; set; }
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tentative Start Date")]
        public string TentativeStartDate { get; set; }
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tentative End Date")]
        public string TentativeEndDate { get; set; }
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Actual Start Date")]
        public string ActualStartDate { get; set; }
        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Actual End Date")]
        public string ActualEndDate { get; set; }
        [Required]
        [Display(Name = "Priority")]
        public string Priority { get; set; }
        [Required]
        [Display(Name = "Budget (Rs.)")]
        public float Budget { get; set; }
        [Required]
        [Display(Name = "Labour Cost (Rs.)")]
        public float LaborCost { get; set; }
        [Required]
        [Display(Name = "Meterial Cost (Rs.)")]
        public float MeterialCost { get; set; }
        [Required]
        [Display(Name = "Fixed Cost (Rs.)")]
        public float FixedCost { get; set; }
        public string Status { get; set; }
        public string CompletionPercentage { get; set; }
        
        [Display(Name = "Remarks")]
        public string ClosingRemarks { get; set; }
        public int SDG_Id { get; set; }
        public int Office_Id { get; set; }
        public int Organization_Id { get; set; }
        public int ProjectManagerId { get; set; }
    }
    public class ProjectManagers
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
    }
    public class ProjectTeams
    {
        public string TeamName { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public int SDGId { get; set; }
    }
    public class TeamMembers
    {
        public int Team_Id { get; set; }
        public int EmployeeId { get; set; }
        public string Role { get; set; }
    }
}