using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Presentation.WinForms.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IMediator _mediator;
        public ProductForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var products = await _mediator.SendAsync(new Application.Query.Product.GetAllProductsQuery());
                this.dataGridViewProducts.DataSource = products;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private async void FormProduct_Shown(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product.ProductCreateForm createForm = new Product.ProductCreateForm(_mediator);
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                FormProduct_Shown(sender, e);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewProducts.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }
            var product = selectedRow.DataBoundItem as Contracts.DTOs.ProductDto;
            if (product == null) return;

            Product.ProductEditForm editForm = new Product.ProductEditForm(_mediator);

            editForm.EditProduct(product);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                FormProduct_Shown(sender, e);
            }
        }

        private async void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewProducts.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um produto antes de deletar.");
                return;
            }

            var dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o produto selecionado?", "Confirmar exclusão", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            var product = selectedRow.DataBoundItem as Contracts.DTOs.ProductDto;
            if (product == null) return;

            var command = new Application.Commands.Product.DeleteProductCommand(product.Id);

            await _mediator.SendAsync(command);

            FormProduct_Shown(sender, e);
        }
    }
}
