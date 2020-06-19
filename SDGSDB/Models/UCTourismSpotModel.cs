using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDGSDB.Models
{
    public class UCTourismSpotModel
    {
        public int TouristSpotId { get; set; }
        [Required]
        [Display(Name = "Tourist Spot Name")]
        public string TouristSpotName { get; set; }
        [Required]
        [Display(Name = "Tourist Spot Category")]
        public int TouristSpotCategory { get; set; }
        [Required]
        [Display(Name = "Popularity")]
        public string Popularity { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Hotel")]
        public bool IsHotel { get; set; }
        [Required]
        [Display(Name = "Restaurant")]
        public bool IsRestaurant { get; set; }
        [Required]
        [Display(Name = "Accommodation)")]
        public bool IsAccommodation { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Shop")]
        public bool IsShop { get; set; }
        [Required]
        [Display(Name = "Time Open")]
        public string TimeOpen { get; set; }
        [Required]
        [Display(Name = "Time Close")]
        public string TimeClose { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}