namespace SalesManager.Presentation.WinForms.Forms.Product
{
    partial class ProductCreateForm
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
            labelName = new Label();
            labelPrice = new Label();
            labelStock = new Label();
            labelDescription = new Label();
            textBoxName = new TextBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            textBoxDescription = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(28, 75);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(37, 15);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Preço";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(28, 109);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(134, 15);
            labelStock.TabIndex = 2;
            labelStock.Text = "Quantidade em estoque";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(28, 144);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(58, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Descrição";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(241, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(253, 23);
            textBoxName.TabIndex = 4;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(241, 73);
            numericUpDownPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(253, 23);
            numericUpDownPrice.TabIndex = 5;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(241, 107);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(253, 23);
            numericUpDownStock.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(241, 141);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(253, 175);
            textBoxDescription.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(405, 353);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(89, 36);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(310, 353);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 36);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ProductCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 411);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(numericUpDownStock);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(labelStock);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            MaximumSize = new Size(550, 450);
            MinimumSize = new Size(550, 450);
            Name = "ProductCreateForm";
            Text = "Cadastro de produto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private Label labelStock;
        private Label labelDescription;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownStock;
        private TextBox textBoxDescription;
        private Button buttonSave;
        private Button buttonCancel;
        private ErrorProvider errorProvider;
    }
}