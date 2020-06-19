using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCTourismSpotGallaryModel
    {
        public int TourismSpotGallaryId { get; set; }
        [Required]
        [Display(Name = "Tourist Spot ID")]
        public int ToursimSpotId { get; set; }
        [Required]
        [Display(Name = "Tourist Spot Image")]
        public string SpotImage { get; set; }
    }
}