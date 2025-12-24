using FluentValidation;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Contracts.DTOs;
using SalesManager.Presentation.WinForms.Extensions;

namespace SalesManager.Presentation.WinForms.Forms.Product
{
    public partial class ProductEditForm : Form
    {
        private readonly IMediator _mediator;
        private Guid _productId;

        public ProductEditForm(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        public void EditProduct(ProductDto product)
        {
            _productId = product.Id;
            textBoxName.Text = product.Name;
            numericUpDownPrice.Value = product.Price;
            numericUpDownStock.Value = product.Stock;
            textBoxDescription.Text = product.Description;
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var command = new Application.Commands.Product.UpdateProductCommand(_productId, textBoxName.Text, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownStock.Value), textBoxDescription.Text);

            try
            {
                var response = await _mediator.SendAsync(command);
            }
            catch (ValidationException ex)
            {
                this.ApplyValidationErrors(ex, errorProvider, GetControlByProperyName);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível editar o produto.");
                this.DialogResult = DialogResult.Cancel;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Control? GetControlByProperyName(string propertyName)
        {
            return propertyName switch
            {
                "Name" => textBoxName,
                "Price" => numericUpDownPrice,
                "Stock" => numericUpDownStock,
                "Description" => textBoxDescription,
                _ => null,
            };
        }
    }
}
