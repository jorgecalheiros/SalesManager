using FluentValidation;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Presentation.WinForms.Extensions;

namespace SalesManager.Presentation.WinForms.Forms.Product
{
    public partial class ProductCreateForm : Form
    {
        private readonly IMediator _mediator;
        public ProductCreateForm(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var command = new Application.Commands.Product.CreateProductCommand(textBoxName.Text, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownStock.Value), textBoxDescription.Text);

            try
            {
                await _mediator.SendAsync(command);
            }
            catch (ValidationException ex)
            {
                this.ApplyValidationErrors(ex, errorProvider, GetControlByProperyName);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível registrar o produto.");
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
