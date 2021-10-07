using System.Collections.Generic;

namespace Lab2.Models
{
    public class WarehouseCell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}