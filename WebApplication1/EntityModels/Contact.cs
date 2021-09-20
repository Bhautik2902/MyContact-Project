using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.EntityModels
{
    public partial class Contact
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? Userid { get; set; }
        [Column("First_name")]
        public string FirstName { get; set; }
        [Column("Last_name")]
        public string LastName { get; set; }
        [Column(TypeName = "character varying")]
        public string Email { get; set; }
        public string Gender { get; set; }
        [Column(TypeName = "character varying")]
        public string Phone { get; set; }
        [Column(TypeName = "character varying")]
        public string Fax { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(User.Contact))]
        public virtual User IdNavigation { get; set; }
    }
}
