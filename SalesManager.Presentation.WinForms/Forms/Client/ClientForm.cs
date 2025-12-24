using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Presentation.WinForms.Forms
{
    public partial class ClientForm : Form
    {
        private readonly IMediator _mediator;
        public ClientForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void ClientForm_Shown(object sender, EventArgs e)
        {
            var products = await _mediator.SendAsync(new Application.Query.Client.GetAllClientQuery());
            dataGridViewClients.DataSource = products;
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            Form clientCreateForm = new Client.ClientCreateForm(_mediator);
            if (clientCreateForm.ShowDialog() == DialogResult.OK)
            {
                ClientForm_Shown(sender, e);
            }
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewClients.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }
            var client = selectedRow.DataBoundItem as Contracts.DTOs.ClientDto;
            if (client == null) return;

            var clientEditForm = new Client.ClientEditForm(_mediator);
            clientEditForm.LoadClient(client);

            if (clientEditForm.ShowDialog() == DialogResult.OK)
            {
                ClientForm_Shown(sender, e);
            }
        }

        private async void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewClients.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um cliente para deletar.");
                return;
            }
            var client = selectedRow.DataBoundItem as Contracts.DTOs.ClientDto;
            if (client == null) return;

            var dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o client selecionado?", "Confirmar exclusão", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            var command = new Application.Commands.Client.DeleteClientCommand(client.Id);
            await _mediator.SendAsync(command);

            ClientForm_Shown(sender, e);
        }
    }
}
