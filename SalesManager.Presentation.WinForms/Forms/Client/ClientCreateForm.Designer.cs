namespace SalesManager.Presentation.WinForms.Forms.Client
{
    partial class ClientCreateForm
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
            textBoxName = new TextBox();
            labelEmail = new Label();
            labelPhoneNumber = new Label();
            textBoxEmail = new TextBox();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(68, 26);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(229, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(161, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(68, 66);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "E-email";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(68, 106);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(113, 15);
            labelPhoneNumber.TabIndex = 3;
            labelPhoneNumber.Text = "Numero de telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(229, 63);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(161, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Location = new Point(229, 106);
            maskedTextBoxPhoneNumber.Mask = "55000000000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(161, 23);
            maskedTextBoxPhoneNumber.TabIndex = 5;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(212, 187);
            buttonCancel.MaximumSize = new Size(86, 32);
            buttonCancel.MinimumSize = new Size(86, 32);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 32);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(304, 187);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 32);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ClientCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 256);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            MaximumSize = new Size(452, 295);
            MinimumSize = new Size(452, 295);
            Name = "ClientCreateForm";
            Text = "Cadastrar cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxPhoneNumber;
        private Button buttonCancel;
        private Button buttonSave;
        private ErrorProvider errorProvider;
    }
}