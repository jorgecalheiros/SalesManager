namespace SalesManager.Presentation.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            buttonSales = new Button();
            buttonClients = new Button();
            buttonProducts = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            labelTitle = new Label();
            buttonCloseChildForm = new Button();
            panelDesktop = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(81, 81, 118);
            panelMenu.Controls.Add(buttonSales);
            panelMenu.Controls.Add(buttonClients);
            panelMenu.Controls.Add(buttonProducts);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 463);
            panelMenu.TabIndex = 0;
            // 
            // buttonSales
            // 
            buttonSales.Dock = DockStyle.Top;
            buttonSales.FlatAppearance.BorderSize = 0;
            buttonSales.FlatStyle = FlatStyle.Flat;
            buttonSales.Font = new Font("Segoe UI", 12F);
            buttonSales.ForeColor = Color.Gainsboro;
            buttonSales.Image = Properties.Resources.vendas_manager;
            buttonSales.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSales.Location = new Point(0, 200);
            buttonSales.Name = "buttonSales";
            buttonSales.Padding = new Padding(12, 0, 0, 0);
            buttonSales.Size = new Size(220, 60);
            buttonSales.TabIndex = 3;
            buttonSales.Text = "  Vendas";
            buttonSales.TextAlign = ContentAlignment.MiddleLeft;
            buttonSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonClients
            // 
            buttonClients.Dock = DockStyle.Top;
            buttonClients.FlatAppearance.BorderSize = 0;
            buttonClients.FlatStyle = FlatStyle.Flat;
            buttonClients.Font = new Font("Segoe UI", 12F);
            buttonClients.ForeColor = Color.Gainsboro;
            buttonClients.Image = Properties.Resources.client_manager;
            buttonClients.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClients.Location = new Point(0, 140);
            buttonClients.Name = "buttonClients";
            buttonClients.Padding = new Padding(12, 0, 0, 0);
            buttonClients.Size = new Size(220, 60);
            buttonClients.TabIndex = 2;
            buttonClients.Text = "  Clientes";
            buttonClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClients.UseVisualStyleBackColor = true;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Dock = DockStyle.Top;
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Segoe UI", 12F);
            buttonProducts.ForeColor = Color.Gainsboro;
            buttonProducts.Image = Properties.Resources.cart_shopping;
            buttonProducts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProducts.Location = new Point(0, 80);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(12, 0, 0, 0);
            buttonProducts.Size = new Size(220, 60);
            buttonProducts.TabIndex = 1;
            buttonProducts.Text = "  Produtos";
            buttonProducts.TextAlign = ContentAlignment.MiddleLeft;
            buttonProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(11, 107, 116);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Sales Manager WinForms";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(19, 178, 192);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Controls.Add(buttonCloseChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(851, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Microsoft Sans Serif", 16F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(85, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(766, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "PRINCIPAL";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCloseChildForm
            // 
            buttonCloseChildForm.Dock = DockStyle.Left;
            buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            buttonCloseChildForm.FlatStyle = FlatStyle.Flat;
            buttonCloseChildForm.Image = Properties.Resources.fechar_x;
            buttonCloseChildForm.Location = new Point(0, 0);
            buttonCloseChildForm.Name = "buttonCloseChildForm";
            buttonCloseChildForm.Size = new Size(85, 80);
            buttonCloseChildForm.TabIndex = 1;
            buttonCloseChildForm.UseVisualStyleBackColor = true;
            buttonCloseChildForm.Click += buttonCloseChildForm_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.Controls.Add(panel1);
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(851, 383);
            panelDesktop.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(253, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 223);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.windows_10_144;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(31, 147);
            label2.Name = "label2";
            label2.Size = new Size(261, 47);
            label2.TabIndex = 1;
            label2.Text = "Sales Manager";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 463);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 500);
            Name = "MainForm";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonProducts;
        private Button buttonSales;
        private Button buttonClients;
        private Panel panelTitleBar;
        private Label labelTitle;
        private Label label1;
        private Panel panelDesktop;
        private Button buttonCloseChildForm;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
    }
}
