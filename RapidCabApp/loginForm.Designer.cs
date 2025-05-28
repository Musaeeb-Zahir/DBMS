namespace RapidCabApp
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.backToHomePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // inpEmail
            // 
            this.inpEmail.Location = new System.Drawing.Point(181, 53);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(100, 20);
            this.inpEmail.TabIndex = 2;
            this.inpEmail.Text = "Enter your email";
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(181, 103);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(100, 20);
            this.inpPassword.TabIndex = 3;
            this.inpPassword.Text = "Enter your password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(341, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // backToHomePage
            // 
            this.backToHomePage.Location = new System.Drawing.Point(458, 100);
            this.backToHomePage.Name = "backToHomePage";
            this.backToHomePage.Size = new System.Drawing.Size(113, 23);
            this.backToHomePage.TabIndex = 5;
            this.backToHomePage.Text = "Back to home page";
            this.backToHomePage.UseVisualStyleBackColor = true;
            this.backToHomePage.Click += new System.EventHandler(this.backToHomePage_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToHomePage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.inpEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button backToHomePage;
    }
}