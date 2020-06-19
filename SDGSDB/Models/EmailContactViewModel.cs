using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class EmailContactViewModel
    {
        public IEnumerable<RegesterNGOContactInsertionModel> NGOContact { get; set; }
        public IEnumerable<RegesterNGOEmailModel> NGOEmail { get; set; }

        
    }
}