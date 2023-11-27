using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class Products
    {
        [Key]
            
            public int ProductID { get; set; }

            [Display(Name = "Product Name")]
            [Required(ErrorMessage = "Name can not blank")]
            public string ProductName { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public int QuantityInStock { get; set; }

            public string CategoryID { get; set; }
            public virtual Catagories Catagories { get; set; }
            public string Image { get; set; }

            public string ImageProducts { get; set; }
    }



    }
