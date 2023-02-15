namespace CashbackUI
{
    partial class RegisterForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.inputPasswordText = new System.Windows.Forms.TextBox();
            this.inputPhoneText = new System.Windows.Forms.TextBox();
            this.inputEmailText = new System.Windows.Forms.TextBox();
            this.inputNameText = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(332, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(332, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 31);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(326, 192);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(99, 31);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Telefone";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(326, 282);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 31);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Senha";
            // 
            // inputPasswordText
            // 
            this.inputPasswordText.Location = new System.Drawing.Point(304, 316);
            this.inputPasswordText.Name = "inputPasswordText";
            this.inputPasswordText.Size = new System.Drawing.Size(125, 38);
            this.inputPasswordText.TabIndex = 4;
            // 
            // inputPhoneText
            // 
            this.inputPhoneText.Location = new System.Drawing.Point(304, 226);
            this.inputPhoneText.Name = "inputPhoneText";
            this.inputPhoneText.Size = new System.Drawing.Size(125, 38);
            this.inputPhoneText.TabIndex = 5;
            // 
            // inputEmailText
            // 
            this.inputEmailText.Location = new System.Drawing.Point(304, 141);
            this.inputEmailText.Name = "inputEmailText";
            this.inputEmailText.Size = new System.Drawing.Size(125, 38);
            this.inputEmailText.TabIndex = 6;
            // 
            // inputNameText
            // 
            this.inputNameText.Location = new System.Drawing.Point(304, 66);
            this.inputNameText.Name = "inputNameText";
            this.inputNameText.Size = new System.Drawing.Size(125, 38);
            this.inputNameText.TabIndex = 7;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(290, 379);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(165, 51);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Registrar";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.inputNameText);
            this.Controls.Add(this.inputEmailText);
            this.Controls.Add(this.inputPhoneText);
            this.Controls.Add(this.inputPasswordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterForm";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label passwordLabel;
        private TextBox inputPasswordText;
        private TextBox inputPhoneText;
        private TextBox inputEmailText;
        private TextBox inputNameText;
        private Button registerBtn;
    }
}