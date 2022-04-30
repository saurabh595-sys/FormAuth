using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormAuth.Models
{
    public class Roles
    {
       
            [Key]
            public int Id { get; set; }
            [Required]
            public string Role { get; set; }

            [Display(Name = "UserId")]
            public virtual int UserId { get; set; }

            [ForeignKey("UserId")]
            public virtual UserDetail UserDetail { get; set; }


        
    }
}