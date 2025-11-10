namespace Gatmaitan_M1_Partial.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderedDate { get; set; }
        public int OrderedQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
