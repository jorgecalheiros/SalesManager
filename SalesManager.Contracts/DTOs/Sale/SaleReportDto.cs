namespace SalesManager.Contracts.DTOs.Sale
{
    public class SaleReportDto
    {
        public string ClientEmail { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public Guid SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal => Quantity * UnitPrice;
    }
}
