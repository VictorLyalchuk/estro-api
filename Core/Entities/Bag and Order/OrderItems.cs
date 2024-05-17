namespace Core.Entities.Information
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
