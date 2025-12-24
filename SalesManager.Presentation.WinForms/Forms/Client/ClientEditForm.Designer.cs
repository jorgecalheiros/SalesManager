namespace SalesManager.Presentation.WinForms.Forms.Client
{
    partial class ClientEditForm
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
            buttonEdit = new Button();
            buttonCancel = new Button();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelPhoneNumber = new Label();
            labelEmail = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(285, 195);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(86, 32);
            buttonEdit.TabIndex = 15;
            buttonEdit.TabStop = false;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(193, 195);
            buttonCancel.MaximumSize = new Size(86, 32);
            buttonCancel.MinimumSize = new Size(86, 32);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 32);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Location = new Point(210, 126);
            maskedTextBoxPhoneNumber.Mask = "55000000000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(161, 23);
            maskedTextBoxPhoneNumber.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(210, 83);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(161, 23);
            textBoxEmail.TabIndex = 12;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(49, 126);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(113, 15);
            labelPhoneNumber.TabIndex = 11;
            labelPhoneNumber.Text = "Numero de telefone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(49, 86);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 15);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "E-email";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(210, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(161, 23);
            textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(49, 46);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Nome";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 256);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            MaximumSize = new Size(452, 295);
            MinimumSize = new Size(452, 295);
            Name = "ClientEditForm";
            Text = "ClientEditForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonCancel;
        private MaskedTextBox maskedTextBoxPhoneNumber;
        private TextBox textBoxEmail;
        private Label labelPhoneNumber;
        private Label labelEmail;
        private TextBox textBoxName;
        private Label labelName;
        private ErrorProvider errorProvider;
    }
}