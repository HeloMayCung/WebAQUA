using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class Customers
    {
            [Key]
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

        

    }
}