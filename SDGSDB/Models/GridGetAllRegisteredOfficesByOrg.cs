using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class GridGetAllRegisteredOfficesByOrg
    {
        public string Organization_Id { get; set; }
        public string Office_Id { get; set; }
        public string Organization_Name { get; set; }
        public string HeadOffice_Name { get; set; }
        public string Address { get; set; }
    }
}