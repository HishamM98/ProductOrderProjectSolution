using System.ComponentModel.DataAnnotations;


namespace PracticeProject.Core.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
