using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CascadeDropdown.Models
{
    public class Country
    {
        public Country()
        {
            Users = new List<User>();
            States = new List<State>();
        }
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}