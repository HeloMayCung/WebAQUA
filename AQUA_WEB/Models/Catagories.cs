using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class Catagories
    {
            [Key]    
            public string CategoryID { get; set; }
            public string CategoryName { get; set; }
        }

    }
