namespace ApplicationService.Dtos.Product
{
    public class PostProductDto
    {
        public string? Code { get; set; }
        public string? Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}