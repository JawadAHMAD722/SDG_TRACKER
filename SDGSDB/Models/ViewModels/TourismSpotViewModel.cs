using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SDGSDB.Models.ViewModels
{   
        public class TourismSpotViewModel
        {
            public UCTourismSpotModel TourismSpotModel { get; set; }
            public UCTourismSpotGallaryModel TourismSpotGallaryModel { get; set; }
        }
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
            public string IsHotel { get; set; }
            [Required]
            [Display(Name = "Restaurant")]
            public string IsRestaurant { get; set; }
            [Required]
            [Display(Name = "Accommodation)")]
            public string IsAccommodation { get; set; }
            [Required]
            [EmailAddress]
            [Display(Name = "Shop")]
            public string IsShop { get; set; }
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