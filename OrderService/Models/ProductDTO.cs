namespace OrderService.Models
{
    public class ResponseDTO
    {
        public ProductDTO Data { get; set; }
    }

    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
