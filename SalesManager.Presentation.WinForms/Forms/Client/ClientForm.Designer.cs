namespace SalesManager.Presentation.WinForms.Forms
{
    partial class ClientForm
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
            dataGridViewClients = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientDtoBindingSource = new BindingSource(components);
            buttonAddClient = new Button();
            buttonEditClient = new Button();
            buttonDeleteClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewClients.AllowUserToOrderColumns = true;
            dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn });
            dataGridViewClients.DataSource = clientDtoBindingSource;
            dataGridViewClients.Location = new Point(61, 100);
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(956, 516);
            dataGridViewClients.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Numero de telefone";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "Cadastrado em";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "Ultima atualização em";
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDtoBindingSource
            // 
            clientDtoBindingSource.DataSource = typeof(Contracts.DTOs.ClientDto);
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(61, 42);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(147, 35);
            buttonAddClient.TabIndex = 1;
            buttonAddClient.Text = "Adicionar cliente";
            buttonAddClient.UseCompatibleTextRendering = true;
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditClient.Location = new Point(816, 42);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(96, 35);
            buttonEditClient.TabIndex = 2;
            buttonEditClient.Text = "Editar";
            buttonEditClient.UseCompatibleTextRendering = true;
            buttonEditClient.UseVisualStyleBackColor = true;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteClient.Location = new Point(918, 42);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(99, 35);
            buttonDeleteClient.TabIndex = 3;
            buttonDeleteClient.Text = "Excluir";
            buttonDeleteClient.UseCompatibleTextRendering = true;
            buttonDeleteClient.UseMnemonic = false;
            buttonDeleteClient.UseVisualStyleBackColor = true;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 652);
            Controls.Add(buttonDeleteClient);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonAddClient);
            Controls.Add(dataGridViewClients);
            MaximumSize = new Size(1427, 691);
            MinimumSize = new Size(857, 691);
            Name = "ClientForm";
            Text = "GESTÃO DE CLIENTES";
            Shown += ClientForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientDtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClients;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private BindingSource clientDtoBindingSource;
        private Button buttonAddClient;
        private Button buttonEditClient;
        private Button buttonDeleteClient;
    }
}