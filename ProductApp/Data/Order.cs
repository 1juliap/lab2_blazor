using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApp.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public float? TotalCost { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
