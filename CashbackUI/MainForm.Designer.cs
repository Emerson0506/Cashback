namespace CashbackUI
{
    partial class MainForm
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.inputPasswordText = new System.Windows.Forms.TextBox();
            this.inputEmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(323, 312);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(123, 45);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Enviar";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // inputPasswordText
            // 
            this.inputPasswordText.Location = new System.Drawing.Point(275, 238);
            this.inputPasswordText.Name = "inputPasswordText";
            this.inputPasswordText.Size = new System.Drawing.Size(235, 33);
            this.inputPasswordText.TabIndex = 7;
            // 
            // inputEmailText
            // 
            this.inputEmailText.Location = new System.Drawing.Point(275, 137);
            this.inputEmailText.Name = "inputEmailText";
            this.inputEmailText.Size = new System.Drawing.Size(235, 33);
            this.inputEmailText.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(189, 140);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(58, 25);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(183, 241);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 25);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Senha";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.inputPasswordText);
            this.Controls.Add(this.inputEmailText);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginBtn;
        private TextBox inputPasswordText;
        private TextBox inputEmailText;
        private Label EmailLabel;
        private Label passwordLabel;
    }
}