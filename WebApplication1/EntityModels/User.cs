using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.EntityModels
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public int Userid { get; set; }
        [Column("First_name")]
        public string FirstName { get; set; }
        [Column("Last_name")]
        public string LastName { get; set; }
        [Column(TypeName = "character varying")]
        public string Email { get; set; }
        public string Gender { get; set; }
        [Column(TypeName = "character varying")]
        public string Password { get; set; }
        [Column("Date_of_Joining", TypeName = "date")]
        public DateTime? DateOfJoining { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual Contact Contact { get; set; }
    }
}
