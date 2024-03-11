namespace InventoryService.Models
{
    public class OrderRequests
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
