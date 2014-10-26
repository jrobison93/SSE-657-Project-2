using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MakerStore.Models
{
    public class Product
    {
        public virtual Category Category { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        [DisplayName("Product Picture URL")]
        [StringLength(1024)]
        public string PictureURL { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.00, double.MaxValue, ErrorMessage = "Price must not be negative")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A Product Name is required")]
        public string Name { get; set; }

        [DisplayName("User")]
        public int UserID { get; set; }

        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}