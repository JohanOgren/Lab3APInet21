using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Description { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<WebbLink> WebbLinks { get; set; }
    }
}
