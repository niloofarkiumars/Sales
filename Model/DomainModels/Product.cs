namespace Model.DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}