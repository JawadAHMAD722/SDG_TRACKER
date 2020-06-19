using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SDGSDB.API.ViewModels
{
    public class OrganizationViewModel
    {
        public string Organization_Name { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Id { get; set; }
        public int Organization_Type_Id { get; set; }

    }
}