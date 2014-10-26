using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MakerStore.Models
{
    internal sealed class SampleData : DbMigrationsConfiguration<MakerStoreEntities>
    {
        public SampleData()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(MakerStoreEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Robotics", CategoryID = 0},
                new Category { Name = "Art", CategoryID = 1},
                new Category { Name = "Wood Working", CategoryID = 2},
                new Category { Name = "Jewelry", CategoryID = 3},
                new Category { Name = "3D Printing", CategoryID = 4},
                new Category { Name = "Music", CategoryID = 5}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();

            var users = new List<UserProfile>
            {
                new UserProfile { UserName = "Admin", UserId = 0},
                new UserProfile { UserName = "Test", UserId = 1}
            };
            context.SaveChanges();

            new List<Product>
            {
                new Product { Name = "Robot", Category = categories.Single(c => c.Name == "Robotics"), Price = 19.99M, User = users.Single(u => u.UserName == "Test"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Painting", Category = categories.Single(c => c.Name == "Art"), Price = 9.99M, User = users.Single(u => u.UserName == "Test"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Song", Category = categories.Single(c => c.Name == "Music"), Price = 9.99M, User = users.Single(u => u.UserName == "Test"), PictureURL = "/Images/placeholder.gif"}
            }.ForEach(a => context.Products.Add(a));
            context.SaveChanges();

        }

    }
}