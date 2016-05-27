using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropdown.Models
{
    public class ProfilePic
    {
        public int ProfilePicId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}