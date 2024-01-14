namespace Rm_Assignment_10.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
