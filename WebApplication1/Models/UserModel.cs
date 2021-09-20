using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression("@(^[a-zA-Z ]*$)", ErrorMessage = "Only alphabets are allowed.")]
        public string firstname { get; set; }
        [Required]
        [RegularExpression("@(^[a-zA-Z ]*$)", ErrorMessage = "Only alphabets are allowed.")]
        [StringLength(100, MinimumLength = 2)]
        public string lastname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Must be between 5 and 15 characters", MinimumLength = 5)]
        public string password { get; set; }
        [Required]
        [Compare("password", ErrorMessage = "Password didn't match. Try again!")]
        public string repass { get; set; }

        public DateTime date_of_register { get; set; }
    }
}
