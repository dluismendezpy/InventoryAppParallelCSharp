using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductAmount { get; set; }
    }
}
