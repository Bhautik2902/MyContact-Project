using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ContactModel
    {
        public int id { get; set; }
        public int userid { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"(^[a-zA-Z ]+$)", ErrorMessage = "Only alphabets are allowed.")]
        public string firstname { get; set; }
        [Required]
        [RegularExpression(@"(^[a-zA-Z ]+$)", ErrorMessage = "Only alphabets are allowed.")]
        [StringLength(100, MinimumLength = 2)]
        public string lastname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        [Phone]
        public string phone { get; set; }
        [Required]
        [Phone]
        public string fax { get; set; }

        public SelectListItem selectedItems { get; set; }

    }
}
