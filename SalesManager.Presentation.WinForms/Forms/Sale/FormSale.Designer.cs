namespace SalesManager.Presentation.WinForms.Forms
{
    partial class FormSale
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewSales = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDtoBindingSource = new BindingSource(components);
            buttonRegisterSale = new Button();
            groupBox1 = new GroupBox();
            buttonGenerateReport = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToOrderColumns = true;
            dataGridViewSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, saleDateDataGridViewTextBoxColumn, clientNameDataGridViewTextBoxColumn, totalValueDataGridViewTextBoxColumn, itemCountDataGridViewTextBoxColumn });
            dataGridViewSales.DataSource = saleDtoBindingSource;
            dataGridViewSales.Location = new Point(40, 234);
            dataGridViewSales.MultiSelect = false;
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.RowHeadersVisible = false;
            dataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSales.Size = new Size(1038, 363);
            dataGridViewSales.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.HeaderText = "Data da venda";
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            clientNameDataGridViewTextBoxColumn.HeaderText = "Nome do cliente";
            clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            totalValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            totalValueDataGridViewTextBoxColumn.HeaderText = "Valor total";
            totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            itemCountDataGridViewTextBoxColumn.HeaderText = "Quantidade de produtos comprados";
            itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            itemCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDtoBindingSource
            // 
            saleDtoBindingSource.DataSource = typeof(Contracts.DTOs.Sale.SaleDto);
            // 
            // buttonRegisterSale
            // 
            buttonRegisterSale.Location = new Point(40, 45);
            buttonRegisterSale.Name = "buttonRegisterSale";
            buttonRegisterSale.Size = new Size(133, 37);
            buttonRegisterSale.TabIndex = 1;
            buttonRegisterSale.Text = "Registrar uma venda";
            buttonRegisterSale.UseVisualStyleBackColor = true;
            buttonRegisterSale.Click += buttonRegisterSale_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonGenerateReport);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Location = new Point(44, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGenerateReport.Location = new Point(893, 50);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(133, 44);
            buttonGenerateReport.TabIndex = 3;
            buttonGenerateReport.Text = "Gerar um relatório";
            buttonGenerateReport.UseVisualStyleBackColor = true;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 39);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "até";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Vendas de:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(308, 33);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(73, 33);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 652);
            Controls.Add(groupBox1);
            Controls.Add(buttonRegisterSale);
            Controls.Add(dataGridViewSales);
            MaximumSize = new Size(1427, 691);
            MinimumSize = new Size(857, 691);
            Name = "FormSale";
            Text = "GESTÃO DE VENDAS";
            Shown += FormSale_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSales;
        private BindingSource saleDtoBindingSource;
        private Button buttonRegisterSale;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Button buttonGenerateReport;
    }
}