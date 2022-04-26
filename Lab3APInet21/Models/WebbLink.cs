using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21.Models
{
    public class WebbLink
    {
        [Key]
        public int WebbLinkId { get; set; }
        [Required]
        public string Link { get; set; }

        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }
    }
}
