using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class Order
    {
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public string item { get; set; }
        public double Cost { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }  
    }

    public class OrderList
    {
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public double TotalCost { get; set; }
    } 
}