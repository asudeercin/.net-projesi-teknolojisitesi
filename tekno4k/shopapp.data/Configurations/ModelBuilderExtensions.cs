using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder) 
        {
            builder.Entity<Product>().HasData(
                new Product(){ProductId=1,Name="Samsung S5",Url="samsung-s5",Price=2000,ImageUrl="1.jpg",Description="iyi telefon", IsApproved=true},
                new Product(){ProductId=2,Name="Samsung S6",Url="samsung-s6",Price=3000,ImageUrl="2.jpg",Description="iyi telefon", IsApproved=false},
                new Product(){ProductId=3,Name="Samsung S7",Url="samsung-s7",Price=4000,ImageUrl="3.jpg",Description="iyi telefon", IsApproved=true},
                new Product(){ProductId=5,Name="Samsung galaxy",Url="Samsung galaxy",Price=4000,ImageUrl="4.jpg",Description="iyi telefon", IsApproved=true},
                new Product(){ProductId=6,Name="iphone x",Url="iphone x",Price=4000,ImageUrl="3.jpg",Description="çok iyi telefon", IsApproved=true},
                new Product(){ProductId=7,Name="asus1",Url="asus1",Price=4000,ImageUrl="asus.jpg",Description="iyi bilgisayar", IsApproved=true},
                new Product(){ProductId=9,Name="lenovo legion",Url="lenovo legion",Price=4000,ImageUrl="lenovo.jpg",Description="iyi telefon", IsApproved=true}
  );

            builder.Entity<Category>().HasData(
                new Category(){CategoryId=1,Name="Telefon",Url="telefon"},
                new Category(){CategoryId=2,Name="Bilgisayar",Url="bilgisayar"},
                new Category(){CategoryId=3,Name="Elektronik",Url="elektronik"}
            );

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory(){ProductId=1,CategoryId=1},          
                new ProductCategory(){ProductId=1,CategoryId=2},          
                new ProductCategory(){ProductId=1,CategoryId=3},          
                new ProductCategory(){ProductId=2,CategoryId=1},          
                new ProductCategory(){ProductId=2,CategoryId=2},          
                new ProductCategory(){ProductId=2,CategoryId=3},          
                new ProductCategory(){ProductId=3,CategoryId=4},          
                new ProductCategory(){ProductId=4,CategoryId=3},          
                new ProductCategory(){ProductId=5,CategoryId=3},          
                new ProductCategory(){ProductId=5,CategoryId=1}       

           );
        }
    }
}