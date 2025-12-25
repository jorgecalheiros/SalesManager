using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Presentation.WinForms.Forms
{
    public partial class FormSale : Form
    {
        private readonly IMediator _mediator;

        public FormSale(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void buttonRegisterSale_Click(object sender, EventArgs e)
        {
            var saleRegisterForm = new Sale.SaleRegisterForm(_mediator);
            if (saleRegisterForm.ShowDialog() == DialogResult.OK)
            {
                FormSale_Shown(sender, e);
            }
        }

        private async void FormSale_Shown(object sender, EventArgs e)
        {
            var sales = await _mediator.SendAsync(new Application.Query.Sale.GetAllSalesQuery());
            this.dataGridViewSales.DataSource = sales;
        }

        private async void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            var salesReport = await _mediator.SendAsync(new Application.Query.Sale.GetSalesByPeriodQuery(
                dateTimePickerStart.Value,
                dateTimePickerEnd.Value
            ));

            Sale.SaleReportForm reportForm = new Sale.SaleReportForm();
            reportForm.SetSalesReports(salesReport);
            reportForm.ShowDialog();
        }
    }
}
