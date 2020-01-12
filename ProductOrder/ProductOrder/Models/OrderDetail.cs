﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class OrderDetail
    {
     
        public double UnitPrize { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }


        [Key]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


        [Key]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

    }
}
