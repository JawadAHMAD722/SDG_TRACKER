using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
        public class OrganizationProfileModel
        {
            public string Organization_Name { get; set; }
            public string Office_Name { get; set; }
            public string Registeration_Date { get; set; }
            public string Person_Contact_Name { get; set; }
            public string Organization_Type_Id { get; set; }
            public string Registeration_Authority { get; set; }
            public string LicenseNo { get; set; }
            public string CompanyCategory { get; set; }
            public string Province_Id { get; set; }
            public string Division_Id { get; set; }
            public string District_Id { get; set; }
            public string Person_Contact_Title { get; set; }    
            public string Person_Contact_Number { get; set; }
            public string Person_Contact_Email { get; set; }
            public string Type_of_Business { get; set; }
            public string Planed_Activity { get; set; }
            public string Additional_Comments { get; set; }
            public string Logo_Image { get; set; }
            public string Province_Name { get; set; }
            public string Division_Name { get; set; }
            public string District_Name { get; set; }
            public string Street { get; set; }
            public string PostalCode { get; set; }
            public string House { get; set; }
            public string[] SDG_Id { get; set; }
            public int Total_Offices { get; set; }
    }
}