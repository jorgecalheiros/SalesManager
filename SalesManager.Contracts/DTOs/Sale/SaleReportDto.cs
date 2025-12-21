using System;

namespace SalesManager.Contracts.DTOs.Sale
{
    public class SaleReportDto
    {
        public Guid SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ItemTotal => Quantity * UnitPrice;
        public decimal SaleTotal { get; set; }
    }
}
