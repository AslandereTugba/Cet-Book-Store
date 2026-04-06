using System.ComponentModel.DataAnnotations;

namespace CetBookStore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}