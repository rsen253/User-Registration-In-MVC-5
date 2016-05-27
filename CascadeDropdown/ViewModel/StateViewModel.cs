using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CascadeDropdown.ViewModel
{
    public class StateViewModel
    {
        public int CountryId { get; set; }
        [Required(ErrorMessage = "State can not be blank")]
        public string StateName { get; set; }
    }
}