using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://placehold.co/600x400/000000/FFF";
        public Category? Category { get; set; } //1-to-1 => A product belongs to a category
        public ICollection<OrderItem>? OrderItems { get; set; } // 1-to-Many a product can be in many order items
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // 1-to-Many a product can be in many order items 
    }
}