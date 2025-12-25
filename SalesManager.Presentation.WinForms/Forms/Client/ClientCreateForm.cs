using FluentValidation;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Presentation.WinForms.Extensions;

namespace SalesManager.Presentation.WinForms.Forms.Client
{
    public partial class ClientCreateForm : Form
    {
        private readonly IMediator _mediator;
        public ClientCreateForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var command = new Application.Commands.Client.CreateClientCommand(
                    textBoxName.Text,
                    textBoxEmail.Text,
                    maskedTextBoxPhoneNumber.Text
                );

                await _mediator.SendAsync(command);
            }
            catch (ValidationException ex)
            {
                this.ApplyValidationErrors(ex, this.errorProvider, GetControlByProperyName);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private Control? GetControlByProperyName(string propertyName)
        {
            return propertyName switch
            {
                "Name" => textBoxName,
                "Email" => textBoxEmail,
                "PhoneNumber" => maskedTextBoxPhoneNumber,
                _ => null,
            };
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
