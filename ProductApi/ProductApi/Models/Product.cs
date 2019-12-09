using System;
using System.Collections.Generic;

namespace ProductApi.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
    }
}
