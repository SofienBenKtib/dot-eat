using doteat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace doteat.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<ProductIngredient> ProductIngredient { get; set; }

        //  Defining the composite key and relatioships for ProductIngredient
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(p => new { p.ProductId, p.IngredientId });
            modelBuilder.Entity<ProductIngredient>()
                .HasOne(p => p.Product)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductIngredient>()
                .HasOne(p => p.Ingredient)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(p => p.IngredientId);

            //  Seeding Data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizer" },
                new Category { CategoryId = 2, Name = "Entree" },
                new Category { CategoryId = 3, Name = "Side Dish" },
                new Category { CategoryId = 4, Name = "Dessert" },
                new Category { CategoryId = 5, Name = "Beverage" }
                );

            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 1, Name = "Beef" },
              new Ingredient { IngredientId = 2, Name = "Chicken" },
              new Ingredient { IngredientId = 3, Name = "Fish" },
              new Ingredient { IngredientId = 4, Name = "Tortilla" },
              new Ingredient { IngredientId = 5, Name = "Lettuce" },
              new Ingredient { IngredientId = 6, Name = "Mushroom" },
              new Ingredient { IngredientId = 7, Name = "Tomato" }
              );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Beef Taco",
                    Description = "A delicious one",
                    Price = 2.5m,
                    Stock = 120,
                    CategoryId = 2,
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Chicken Taco",
                    Description = "A smooth one",
                    Price = 2,
                    Stock = 150,
                    CategoryId = 2,
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Fish Taco",
                    Description = "A yummy one",
                    Price = 2.2m,
                    Stock = 100,
                    CategoryId = 2,
                }
                );
            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient { ProductId=1, IngredientId=1},
                new ProductIngredient { ProductId=1, IngredientId=4},
                new ProductIngredient { ProductId=1, IngredientId=5},
                new ProductIngredient { ProductId=1, IngredientId=6},
                new ProductIngredient { ProductId=2, IngredientId=2},
                new ProductIngredient { ProductId=2, IngredientId=4},
                new ProductIngredient { ProductId=2, IngredientId=5},
                new ProductIngredient { ProductId=2, IngredientId=6},
                new ProductIngredient { ProductId=3, IngredientId=3},
                new ProductIngredient { ProductId=3, IngredientId=4},
                new ProductIngredient { ProductId=3, IngredientId=5},
                new ProductIngredient { ProductId=3, IngredientId=6}
                );
        }
    }
}
