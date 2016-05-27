using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropdown.Models
{
    public class State
    {
        public State()
        {
            Users = new List<User>();
        }
        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}