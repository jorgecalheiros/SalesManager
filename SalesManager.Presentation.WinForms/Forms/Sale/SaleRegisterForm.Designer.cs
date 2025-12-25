namespace SalesManager.Presentation.WinForms.Forms.Sale
{
    partial class SaleRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBoxClient = new ComboBox();
            clientDtoBindingSource = new BindingSource(components);
            label2 = new Label();
            comboBoxProduct = new ComboBox();
            productDtoBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            buttonAddProductItem = new Button();
            numericUpDownProductQuant = new NumericUpDown();
            label7 = new Label();
            labelProductDescription = new Label();
            labelProductPrice = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            labelClientPhoneNumber = new Label();
            labelClientName = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridViewProductItem = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleItemDtoBindingSource = new BindingSource(components);
            buttonRegisterSale = new Button();
            label9 = new Label();
            labelSaleTotal = new Label();
            buttonCancel = new Button();
            label8 = new Label();
            labelStock = new Label();
            ((System.ComponentModel.ISupportInitialize)clientDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductQuant).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleItemDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o email do cliente";
            // 
            // comboBoxClient
            // 
            comboBoxClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClient.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClient.DataSource = clientDtoBindingSource;
            comboBoxClient.DisplayMember = "Email";
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(147, 25);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(168, 23);
            comboBoxClient.TabIndex = 1;
            comboBoxClient.ValueMember = "Email";
            comboBoxClient.SelectedValueChanged += comboBoxClient_SelectedValueChanged;
            // 
            // clientDtoBindingSource
            // 
            clientDtoBindingSource.DataSource = typeof(Contracts.DTOs.ClientDto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Escolha o produto";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProduct.DataSource = productDtoBindingSource;
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(147, 32);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(168, 23);
            comboBoxProduct.TabIndex = 3;
            comboBoxProduct.ValueMember = "Id";
            comboBoxProduct.SelectedValueChanged += comboBoxProduct_SelectedValueChanged;
            // 
            // productDtoBindingSource
            // 
            productDtoBindingSource.DataSource = typeof(Contracts.DTOs.ProductDto);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(labelStock);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(buttonAddProductItem);
            groupBox1.Controls.Add(numericUpDownProductQuant);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelProductDescription);
            groupBox1.Controls.Add(labelProductPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxProduct);
            groupBox1.Location = new Point(54, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // buttonAddProductItem
            // 
            buttonAddProductItem.Location = new Point(6, 132);
            buttonAddProductItem.Name = "buttonAddProductItem";
            buttonAddProductItem.Size = new Size(90, 38);
            buttonAddProductItem.TabIndex = 6;
            buttonAddProductItem.Text = "Adicionar";
            buttonAddProductItem.UseVisualStyleBackColor = true;
            buttonAddProductItem.Click += buttonAddProductItem_Click;
            // 
            // numericUpDownProductQuant
            // 
            numericUpDownProductQuant.Location = new Point(147, 66);
            numericUpDownProductQuant.Name = "numericUpDownProductQuant";
            numericUpDownProductQuant.Size = new Size(120, 23);
            numericUpDownProductQuant.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 68);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 7;
            label7.Text = "Informe a quantidade";
            // 
            // labelProductDescription
            // 
            labelProductDescription.AutoSize = true;
            labelProductDescription.Location = new Point(421, 66);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(0, 15);
            labelProductDescription.TabIndex = 6;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new Point(421, 32);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(0, 15);
            labelProductPrice.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(357, 66);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(357, 32);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(labelClientPhoneNumber);
            groupBox2.Controls.Add(labelClientName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxClient);
            groupBox2.Location = new Point(54, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(668, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // labelClientPhoneNumber
            // 
            labelClientPhoneNumber.AutoSize = true;
            labelClientPhoneNumber.Location = new Point(421, 62);
            labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            labelClientPhoneNumber.Size = new Size(0, 15);
            labelClientPhoneNumber.TabIndex = 5;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(421, 25);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 15);
            labelClientName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(356, 62);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(357, 25);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // dataGridViewProductItem
            // 
            dataGridViewProductItem.AllowUserToAddRows = false;
            dataGridViewProductItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductItem.AutoGenerateColumns = false;
            dataGridViewProductItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductItem.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridViewProductItem.DataSource = saleItemDtoBindingSource;
            dataGridViewProductItem.Location = new Point(54, 340);
            dataGridViewProductItem.MultiSelect = false;
            dataGridViewProductItem.Name = "dataGridViewProductItem";
            dataGridViewProductItem.RowHeadersVisible = false;
            dataGridViewProductItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductItem.Size = new Size(668, 260);
            dataGridViewProductItem.TabIndex = 6;
            dataGridViewProductItem.CellValueChanged += dataGridViewProductItem_CellValueChanged;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Nome do produto";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "Preço unitário";
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "Preço total";
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleItemDtoBindingSource
            // 
            saleItemDtoBindingSource.DataSource = typeof(Contracts.DTOs.Sale.SaleItemDto);
            // 
            // buttonRegisterSale
            // 
            buttonRegisterSale.Location = new Point(54, 608);
            buttonRegisterSale.Name = "buttonRegisterSale";
            buttonRegisterSale.Size = new Size(123, 38);
            buttonRegisterSale.TabIndex = 11;
            buttonRegisterSale.Text = "Registrar venda";
            buttonRegisterSale.UseVisualStyleBackColor = true;
            buttonRegisterSale.Click += buttonRegisterSale_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(572, 608);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 11;
            label9.Text = "Total:";
            // 
            // labelSaleTotal
            // 
            labelSaleTotal.AutoSize = true;
            labelSaleTotal.Location = new Point(615, 608);
            labelSaleTotal.Name = "labelSaleTotal";
            labelSaleTotal.Size = new Size(0, 15);
            labelSaleTotal.TabIndex = 12;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(183, 608);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(123, 38);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(360, 103);
            label8.Name = "label8";
            label8.Size = new Size(143, 15);
            label8.TabIndex = 9;
            label8.Text = "Quantidade em estoque:";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(508, 103);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(0, 15);
            labelStock.TabIndex = 10;
            // 
            // SaleRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 658);
            Controls.Add(labelSaleTotal);
            Controls.Add(buttonCancel);
            Controls.Add(label9);
            Controls.Add(buttonRegisterSale);
            Controls.Add(dataGridViewProductItem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1387, 800);
            MinimumSize = new Size(803, 697);
            Name = "SaleRegisterForm";
            Text = "REGISTRAR UMA VENDA";
            Load += SaleRegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)clientDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductQuant).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleItemDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxClient;
        private BindingSource clientDtoBindingSource;
        private Label label2;
        private ComboBox comboBoxProduct;
        private BindingSource productDtoBindingSource;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label labelProductDescription;
        private Label labelProductPrice;
        private Label labelClientPhoneNumber;
        private Label labelClientName;
        private NumericUpDown numericUpDownProductQuant;
        private Label label7;
        private Button buttonAddProductItem;
        private DataGridView dataGridViewProductItem;
        private BindingSource saleItemDtoBindingSource;
        private Button buttonRegisterSale;
        private Label label9;
        private Label labelSaleTotal;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private Button buttonCancel;
        private Label label8;
        private Label labelStock;
    }
}