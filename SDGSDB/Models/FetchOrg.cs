using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class FetchOrg
    {
        public int Organization_Id { get; set; }
        public int Office_Id { get; set; }

        public string Organization_Name { get; set; }


        public string Contact_Number { get; set; }


        public string Email_Id { get; set; }

    }
}