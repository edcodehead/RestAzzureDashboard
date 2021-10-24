using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WellnessApp.Core
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
