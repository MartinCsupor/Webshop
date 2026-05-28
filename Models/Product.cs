using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Models
{
    internal class Product
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public double Weight { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
