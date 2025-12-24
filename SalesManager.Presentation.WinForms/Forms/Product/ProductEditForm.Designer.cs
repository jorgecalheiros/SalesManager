namespace SalesManager.Presentation.WinForms.Forms.Product
{
    partial class ProductEditForm
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
            buttonCancel = new Button();
            buttonEdit = new Button();
            numericUpDownStock = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            textBoxName = new TextBox();
            labelDescription = new Label();
            labelStock = new Label();
            labelPrice = new Label();
            labelName = new Label();
            textBoxDescription = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(320, 351);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 36);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(415, 351);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(89, 36);
            buttonEdit.TabIndex = 18;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(251, 105);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(253, 23);
            numericUpDownStock.TabIndex = 16;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(251, 71);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(253, 23);
            numericUpDownPrice.TabIndex = 15;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(251, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(253, 23);
            textBoxName.TabIndex = 14;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(38, 142);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(58, 15);
            labelDescription.TabIndex = 13;
            labelDescription.Text = "Descrição";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(38, 107);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(134, 15);
            labelStock.TabIndex = 12;
            labelStock.Text = "Quantidade em estoque";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(38, 73);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(37, 15);
            labelPrice.TabIndex = 11;
            labelPrice.Text = "Preço";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(38, 36);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 10;
            labelName.Text = "Nome";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(251, 142);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(253, 175);
            textBoxDescription.TabIndex = 20;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 411);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(numericUpDownStock);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(labelStock);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            MaximumSize = new Size(550, 450);
            MinimumSize = new Size(550, 450);
            Name = "ProductEditForm";
            Text = "Editar produto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonEdit;
        private NumericUpDown numericUpDownStock;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxName;
        private Label labelDescription;
        private Label labelStock;
        private Label labelPrice;
        private Label labelName;
        private TextBox textBoxDescription;
        private ErrorProvider errorProvider;
    }
}