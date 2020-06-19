using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class GetRegisteredOfficeContact
    {
        public int Contact_Id { get; set; }
        public string Contact_Number { get; set; }
        public string Fax { get; set; }
        public string Website_URL { get; set; }
    }
}