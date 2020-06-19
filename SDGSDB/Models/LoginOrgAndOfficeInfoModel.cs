using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class LoginOrgAndOfficeInfoModel
    {
        public string Organization_Name { get; set; }
        public string Office_Name { get; set; }
        public string Logo_Image { get; set; }
        public string Organization_Type_Id { get; set; }
        public string Type_of_Business { get; set; }
        public string Planed_Activity { get; set; }
        public string Additional_Comments { get; set; }
        public string Person_Contat_Email { get; set; }
    }
}