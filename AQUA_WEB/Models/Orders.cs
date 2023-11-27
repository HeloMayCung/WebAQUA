using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class Orders
    {
        [Key]
            public int OrderID { get; set; }
            public int CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public int Quantity { get; set; }
            public decimal TotalAmount { get; set; }
            public virtual Customers Customer { get; set; }
            



    }
}