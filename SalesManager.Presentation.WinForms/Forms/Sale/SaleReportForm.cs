using Microsoft.Reporting.WinForms;
using SalesManager.Contracts.DTOs.Sale;

namespace SalesManager.Presentation.WinForms.Forms.Sale
{
    public partial class SaleReportForm : Form
    {
        private readonly ReportViewer _reportViewer;
        private readonly List<SaleReportDto> SalesReport = new();
        public SaleReportForm()
        {
            InitializeComponent();
            _reportViewer = new ReportViewer();
            _reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(_reportViewer);
        }

        public void SetSalesReports(List<SaleReportDto> salesReports)
        {
            SalesReport.Clear();
            SalesReport.AddRange(salesReports);
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            var total = SalesReport.Sum(s => s.ItemTotal);
            var parameters = new[]
{
                new ReportParameter("TotalGeral", total.ToString("C2"))
            };

            using var fs = new FileStream("SalesReport.rdlc", FileMode.Open);
            _reportViewer.LocalReport.LoadReportDefinition(fs);
            _reportViewer.LocalReport.SetParameters(parameters);
            _reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Vendas", SalesReport));
            _reportViewer.RefreshReport();
        }
    }
}
