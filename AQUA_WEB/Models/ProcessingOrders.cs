using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class ProcessingOrders
    {

        [Key]
            public int ProcessingOrderID { get; set; }
            public int OrderID { get; set; }
            public string Status { get; set; }
            public DateTime ProcessStartDate { get; set; }
            public DateTime? ProcessEndDate { get; set; }
            public virtual Orders Order { get; set; }
        

    }
}