namespace SalesManager.Contracts.DTOs.Sale
{
    public class SaleDto
    {
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public decimal TotalValue { get; set; }
        public int ItemCount { get; set; }
    }
}
