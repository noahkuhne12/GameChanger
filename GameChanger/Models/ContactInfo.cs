using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameChanger.Models
{
    public class ContactInfo
    {
        [Required]
        public string Fuldenave { get; set; }
        public string Email { get; set; }
        public string Besked { get; set; }

    }
}
