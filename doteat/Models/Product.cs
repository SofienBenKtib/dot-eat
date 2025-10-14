namespace doteat.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } //1-to-1 => A product belongs to a category
        public ICollection<OrderItem>? OrderItems { get; set; } // 1-to-Many a product can be in many order items
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // 1-to-Many a product can be in many order items 
    }
}