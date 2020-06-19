using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCProfile
    {
        public int UC_Id { get; set; }
        public string UC_Name { get; set; }
        public string Province_Name { get; set; }
        public string Division_Name { get; set; }
        public string District_Name { get; set; }
        public string Tehsil_Name { get; set; }
        public string Area { get; set; }
        public string Population { get; set; }
        public string MalePopulation { get; set; }
        public string FemalePopulation { get; set; }
        public string OtherLocality { get; set; }
        public string Climate { get; set; }
        public string RoadInfrastructure { get; set; }
        public string Organization_Type_Id { get; set; }
        public string Name { get; set; }
        public string Person_Contat_Number { get; set; }
        public string Person_Contat_Email { get; set; }

    }
}