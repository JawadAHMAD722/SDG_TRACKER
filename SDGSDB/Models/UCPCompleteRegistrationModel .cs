using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCPCompleteRegistrationModel
    {
        [Required]
        [Display(Name = "UC Area")]
        public string Area { get; set; }
        [Required]
        [Display(Name = "Population")]
        public string Population { get; set; }
        
        [Required]
        [Display(Name = "Male Population")]
        public string MalePopulation { get; set; }
        [Required]
        [Display(Name = "Female Population")]
        public string FemalePopulation { get; set; }
        [Required]
        [Display(Name = "Locality")]
        public string Other_Locality { get; set; }
        [Required]
        [Display(Name = "Climate")]
        public string Climate { get; set; }
        
        [Required]
        [Display(Name = "RoadInfrastructure")]
        public string RoadInfrastructure { get; set; }
       
    }
}