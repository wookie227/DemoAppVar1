namespace DemoAppVar1
{
    partial class Auth
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
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            AuthBtn = new Button();
            SuspendLayout();
            // 
            // LoginTB
            // 
            LoginTB.Location = new Point(61, 78);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(100, 23);
            LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(61, 127);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(100, 23);
            PasswordTB.TabIndex = 1;
            // 
            // AuthBtn
            // 
            AuthBtn.Location = new Point(74, 177);
            AuthBtn.Name = "AuthBtn";
            AuthBtn.Size = new Size(75, 23);
            AuthBtn.TabIndex = 2;
            AuthBtn.Text = "Войти";
            AuthBtn.UseVisualStyleBackColor = true;
            AuthBtn.Click += AuthBtn_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 275);
            Controls.Add(AuthBtn);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Button AuthBtn;
    }
}