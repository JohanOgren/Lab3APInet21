using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string PhoneNumber { get; set; }

        public ICollection<Hobby> Hobbies { get; set; }
    }
}
