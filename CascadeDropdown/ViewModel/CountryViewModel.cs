using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CascadeDropdown.ViewModel
{
    public class CountryViewModel
    {
        
        [Required(ErrorMessage = "Country can not be blank")]
        public string CountryName { get; set; }
    }
}