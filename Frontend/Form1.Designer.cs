namespace Frontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            signupButton = new Button();
            firstPanel = new Panel();
            loginPanel = new Panel();
            loginSubmitButton = new Button();
            loginUsernamTB = new TextBox();
            loginPasswordTB = new TextBox();
            signupPanel = new Panel();
            signupSubmitBT = new Button();
            signupUsernameTB = new TextBox();
            signupPasswordTB = new TextBox();
            homePanel = new Panel();
            firstPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            signupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Yellow;
            loginButton.Location = new Point(326, 259);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(206, 62);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.Yellow;
            signupButton.Location = new Point(326, 751);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(206, 62);
            signupButton.TabIndex = 1;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            // 
            // firstPanel
            // 
            firstPanel.Controls.Add(loginButton);
            firstPanel.Controls.Add(signupButton);
            firstPanel.Dock = DockStyle.Fill;
            firstPanel.Location = new Point(0, 0);
            firstPanel.Name = "firstPanel";
            firstPanel.Size = new Size(884, 1061);
            firstPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Cyan;
            loginPanel.Controls.Add(loginPasswordTB);
            loginPanel.Controls.Add(loginUsernamTB);
            loginPanel.Controls.Add(loginSubmitButton);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(884, 1061);
            loginPanel.TabIndex = 2;
            // 
            // loginSubmitButton
            // 
            loginSubmitButton.BackColor = Color.Fuchsia;
            loginSubmitButton.Location = new Point(171, 471);
            loginSubmitButton.Name = "loginSubmitButton";
            loginSubmitButton.Size = new Size(558, 315);
            loginSubmitButton.TabIndex = 0;
            loginSubmitButton.Text = "LOGIN";
            loginSubmitButton.UseVisualStyleBackColor = false;
            // 
            // loginUsernamTB
            // 
            loginUsernamTB.BackColor = Color.Fuchsia;
            loginUsernamTB.Location = new Point(274, 61);
            loginUsernamTB.Name = "loginUsernamTB";
            loginUsernamTB.PlaceholderText = "Username";
            loginUsernamTB.Size = new Size(348, 23);
            loginUsernamTB.TabIndex = 1;
            // 
            // loginPasswordTB
            // 
            loginPasswordTB.BackColor = Color.Fuchsia;
            loginPasswordTB.Location = new Point(274, 230);
            loginPasswordTB.Name = "loginPasswordTB";
            loginPasswordTB.PlaceholderText = "Password";
            loginPasswordTB.Size = new Size(348, 23);
            loginPasswordTB.TabIndex = 2;
            // 
            // signupPanel
            // 
            signupPanel.BackColor = Color.Red;
            signupPanel.Controls.Add(signupPasswordTB);
            signupPanel.Controls.Add(signupUsernameTB);
            signupPanel.Controls.Add(signupSubmitBT);
            signupPanel.Dock = DockStyle.Fill;
            signupPanel.Location = new Point(0, 0);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(884, 1061);
            signupPanel.TabIndex = 3;
            // 
            // signupSubmitBT
            // 
            signupSubmitBT.BackColor = Color.Orange;
            signupSubmitBT.Location = new Point(213, 667);
            signupSubmitBT.Name = "signupSubmitBT";
            signupSubmitBT.Size = new Size(470, 183);
            signupSubmitBT.TabIndex = 0;
            signupSubmitBT.Text = "SIGN UP";
            signupSubmitBT.UseVisualStyleBackColor = false;
            // 
            // signupUsernameTB
            // 
            signupUsernameTB.BackColor = Color.FromArgb(255, 128, 0);
            signupUsernameTB.Location = new Point(237, 136);
            signupUsernameTB.Name = "signupUsernameTB";
            signupUsernameTB.PlaceholderText = "Username";
            signupUsernameTB.Size = new Size(408, 23);
            signupUsernameTB.TabIndex = 1;
            // 
            // signupPasswordTB
            // 
            signupPasswordTB.BackColor = Color.FromArgb(255, 128, 0);
            signupPasswordTB.Location = new Point(237, 351);
            signupPasswordTB.Name = "signupPasswordTB";
            signupPasswordTB.PlaceholderText = "Password";
            signupPasswordTB.Size = new Size(408, 23);
            signupPasswordTB.TabIndex = 2;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.White;
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(884, 1061);
            homePanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(884, 1061);
            Controls.Add(homePanel);
            Controls.Add(signupPanel);
            Controls.Add(loginPanel);
            Controls.Add(firstPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            firstPanel.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Button signupButton;
        private Panel firstPanel;
        private Panel loginPanel;
        private TextBox loginPasswordTB;
        private TextBox loginUsernamTB;
        private Button loginSubmitButton;
        private Panel signupPanel;
        private TextBox signupPasswordTB;
        private TextBox signupUsernameTB;
        private Button signupSubmitBT;
        private Panel homePanel;
    }
}
