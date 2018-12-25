using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStore.DAL.Entities
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
