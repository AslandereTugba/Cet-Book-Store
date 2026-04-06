using System.ComponentModel.DataAnnotations;

namespace CetBookStore.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; } = null!;

        [Range(1, 100)]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; } = null!;

        public virtual Book Book { get; set; } = null!;
    }
}