using System;
using System.Collections.Generic;
using System.Text;

namespace UserAdmin.Models
{
    class User
    {
        public int? Id { get; set; }
        public string? Userbame { get; set; }
        public string?  Password { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
