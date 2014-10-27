using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MakerStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<MakerStoreEntities>
    {
        protected override void Seed(MakerStoreEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Robotics"},
                new Category { Name = "Art"},
                new Category { Name = "Wood Working"},
                new Category { Name = "3D Printing"},
                new Category { Name = "Music"}
            };

            var users = new List<UserProfile>
            {
                new UserProfile { UserName = "Admin"},
                new UserProfile { UserName = "Test"},
                new UserProfile { UserName = "Micheal Rose", Biography = "I am very commited to pushing the Macon maker's movement. My passion is to create excellent software. In my spare time I create classical music.", PictureURL = "/Images/placeholder.gif"},
                new UserProfile { UserName = "Bob Martin", Biography = "I create hand crafted canoes from wood.", PictureURL = "/Images/placeholder.gif"},
                new UserProfile { UserName = "Tanya Do", Biography = "I create oil paintings of landscapes.", PictureURL = "/Images/placeholder.gif"},
                new UserProfile { UserName = "John Robison", Biography = "I create robotic systems.", PictureURL = "/Images/placeholder.gif"},
                new UserProfile { UserName = "Paul MacNeil", Biography = "I create 3D printed sculptures.", PictureURL = "/Images/placeholder.gif"}
            };

            new List<Product>
            {
                new Product { Name = "Robot", Category = categories.Single(c => c.Name == "Robotics"), Price = 19.99M, User = users.Single(u => u.UserName == "John Robison"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Painting", Category = categories.Single(c => c.Name == "Art"), Price = 9.99M, User = users.Single(u => u.UserName == "Tanya Do"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Song", Category = categories.Single(c => c.Name == "Music"), Price = 9.99M, User = users.Single(u => u.UserName == "Micheal Rose"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Canoe", Category = categories.Single(c => c.Name == "Wood Working"), Price = 109.99M, User = users.Single(u => u.UserName == "Bob Martin"), PictureURL = "/Images/placeholder.gif"},
                new Product { Name = "Sculpture", Category = categories.Single(c => c.Name == "3D Printing"), Price = 9.99M, User = users.Single(u => u.UserName == "Paul MacNeil"), PictureURL = "/Images/placeholder.gif"}
            }.ForEach(a => context.Products.Add(a));

        }

    }
}