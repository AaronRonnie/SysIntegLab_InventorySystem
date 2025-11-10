namespace Gatmaitan_M1_Partial.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string OrderedBy { get; set; }
        public string ShippedTo { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}
