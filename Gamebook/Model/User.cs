using Gamebook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "login")]
        public string login { get; set; }
        [Required]
        [Display(Name ="password")]
        public string password { get; set; }
    }
}
