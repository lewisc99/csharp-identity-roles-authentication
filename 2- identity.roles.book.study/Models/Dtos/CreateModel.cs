using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2__identity.roles.book.study.Models.Dtos
{
    public class CreateModel
    {

        [Required]
       public string Name { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
