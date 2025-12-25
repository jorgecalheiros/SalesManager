using SalesManager.Application.Common.SimpleMediator.Interfaces;
using System.Data;

namespace SalesManager.Presentation.WinForms.Forms.Sale
{
    public partial class SaleRegisterForm : Form
    {
        private readonly IMediator _mediator;
        private List<Contracts.DTOs.Sale.SaleItemDto> saleItems = new();

        public SaleRegisterForm(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private async void SaleRegisterForm_Load(object sender, EventArgs e)
        {
            var clients = await _mediator.SendAsync(new Application.Query.Client.GetAllClientQuery());
            this.comboBoxClient.DataSource = clients;

            var products = await _mediator.SendAsync(new Application.Query.Product.GetAllProductsQuery());
            this.comboBoxProduct.DataSource = products;

        }

        private void comboBoxClient_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClient = this.comboBoxClient.SelectedItem as Contracts.DTOs.ClientDto;
            if (selectedClient != null)
            {
                this.labelClientName.Text = selectedClient.Name.ToString();
                this.labelClientPhoneNumber.Text = selectedClient.PhoneNumber.ToString();
            }
        }

        private void comboBoxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedProduct = this.comboBoxProduct.SelectedItem as Contracts.DTOs.ProductDto;
            if (selectedProduct != null)
            {
                this.labelProductPrice.Text = selectedProduct.Price.ToString("C2");
                this.labelProductDescription.Text = selectedProduct.Description.ToString();
                this.labelStock.Text = selectedProduct.Stock.ToString();
            }
        }

        private async void buttonRegisterSale_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = this.comboBoxClient.SelectedItem as Contracts.DTOs.ClientDto;
                if (selectedClient == null)
                {
                    MessageBox.Show("Selecione um cliente para registrar a venda.", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var items = saleItems.Select(item => new Application.Commands.Sale.SaleItemCommand
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                }).ToList();
                var command = new Application.Commands.Sale.RegisterSaleCommand(selectedClient.Id, items);

                await _mediator.SendAsync(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
        private void buttonAddProductItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = this.comboBoxProduct.SelectedItem as Contracts.DTOs.ProductDto;
            if (selectedProduct != null)
            {
                var quantity = (int)this.numericUpDownProductQuant.Value;
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantidade não pode ser menor ou igual a zero.", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var saleItem = new Contracts.DTOs.Sale.SaleItemDto
                {
                    ProductId = selectedProduct.Id,
                    ProductName = selectedProduct.Name,
                    Quantity = quantity,
                    UnitPrice = selectedProduct.Price
                };
                saleItems.Add(saleItem);
                this.dataGridViewProductItem.DataSource = null;
                this.dataGridViewProductItem.DataSource = saleItems;
                this.labelSaleTotal.Text = saleItems.Sum(item => item.SubTotal).ToString("C2");
            }
        }

        private void dataGridViewProductItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var updatedItem = this.dataGridViewProductItem.Rows[e.RowIndex].DataBoundItem as Contracts.DTOs.Sale.SaleItemDto;

            if (updatedItem != null)
            {
                if (updatedItem.Quantity <= 0)
                {
                    MessageBox.Show("Quantidade não pode ser menor ou igual a zero.", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    updatedItem.Quantity = 1;
                    return;
                }

                this.dataGridViewProductItem.EndEdit();

                this.dataGridViewProductItem.InvalidateRow(e.RowIndex);

                this.labelSaleTotal.Text = saleItems.Sum(item => item.SubTotal).ToString("C2");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
