using System.ComponentModel;

namespace EShopSErvice.Models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string ean { get; set; } = default!;

        public decimal price { get; set; }

        public int stock { get; set; } = 0;

        public string sku { get; set; } = default!;

        public Category? Category { get; set; }

    }
}
