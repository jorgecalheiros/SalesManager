using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Presentation.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Form? activeForm = null;
        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this.buttonCloseChildForm.Visible = false;
        }

        private void ActiveButton(object sender)
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(81, 81, 118);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
            Button currentBtn = (Button)sender;
            currentBtn.BackColor = Color.FromArgb(19, 178, 192);
            currentBtn.ForeColor = Color.White;
            this.buttonCloseChildForm.Visible = true;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.ProductForm(GetMediator()), sender);
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ClientForm(GetMediator()), sender);
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSale(GetMediator()), sender);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            labelTitle.Text = "PRINCIPAL";
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(81, 81, 118);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
            this.buttonCloseChildForm.Visible = false;
        }

        private IMediator GetMediator()
        {
            var scope = _serviceProvider.CreateScope();
            return scope.ServiceProvider.GetRequiredService<IMediator>();
        }
    }
}
