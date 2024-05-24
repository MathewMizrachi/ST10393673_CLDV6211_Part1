using Microsoft.AspNetCore.Identity;

namespace ST10393673_CLDV6211_Part1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int Availability { get; set; }
        public string ImageURL { get; set; }

        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }

    public class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
    }
}
