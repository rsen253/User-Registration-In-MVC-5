using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropdown.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Country Counrty { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<ProfilePic> ProfilePics { get; set; }
    }
}