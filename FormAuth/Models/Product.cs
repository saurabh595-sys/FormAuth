using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormAuth.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }


        [Display(Name = "Category_model")]
        public virtual int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Catagory Category { get; set; }


    }
}