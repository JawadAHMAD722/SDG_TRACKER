using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class GetRegistrationModel
    {
        public string Organization_Name { get; set; }
        public string Organization_Type_Id { get; set; }
        public string Email_Id { get; set; }
        public string Contact_Number { get; set; }
        public string BusinessType { get; set; }
        public string Planned_Activities { get; set; }
        public string Additional_Comments { get; set; }
    }
}