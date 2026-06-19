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
            introLabel = new Label();
            homePanel = new Panel();
            bt_addMember = new Button();
            bt_addLibrary = new Button();
            bt_addBook = new Button();
            button1 = new Button();
            button2 = new Button();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // introLabel
            // 
            introLabel.AutoSize = true;
            introLabel.Font = new Font("Segoe UI", 20F);
            introLabel.ForeColor = SystemColors.ButtonFace;
            introLabel.Location = new Point(130, 9);
            introLabel.Name = "introLabel";
            introLabel.Size = new Size(510, 46);
            introLabel.TabIndex = 0;
            introLabel.Text = "Welcome to the Library Assistant";
            // 
            // homePanel
            // 
            homePanel.BackColor = SystemColors.Desktop;
            homePanel.Controls.Add(button2);
            homePanel.Controls.Add(button1);
            homePanel.Controls.Add(bt_addMember);
            homePanel.Controls.Add(bt_addLibrary);
            homePanel.Controls.Add(bt_addBook);
            homePanel.Controls.Add(introLabel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(800, 450);
            homePanel.TabIndex = 1;
            // 
            // bt_addMember
            // 
            bt_addMember.BackColor = SystemColors.Desktop;
            bt_addMember.ForeColor = SystemColors.ButtonFace;
            bt_addMember.Location = new Point(312, 409);
            bt_addMember.Name = "bt_addMember";
            bt_addMember.Size = new Size(176, 29);
            bt_addMember.TabIndex = 3;
            bt_addMember.Text = "Register Member";
            bt_addMember.UseVisualStyleBackColor = false;
            // 
            // bt_addLibrary
            // 
            bt_addLibrary.BackColor = SystemColors.Desktop;
            bt_addLibrary.ForeColor = SystemColors.ButtonFace;
            bt_addLibrary.Location = new Point(612, 409);
            bt_addLibrary.Name = "bt_addLibrary";
            bt_addLibrary.Size = new Size(176, 29);
            bt_addLibrary.TabIndex = 2;
            bt_addLibrary.Text = "Add Library to System";
            bt_addLibrary.UseVisualStyleBackColor = false;
            // 
            // bt_addBook
            // 
            bt_addBook.BackColor = SystemColors.Desktop;
            bt_addBook.ForeColor = SystemColors.ButtonFace;
            bt_addBook.Location = new Point(12, 409);
            bt_addBook.Name = "bt_addBook";
            bt_addBook.Size = new Size(176, 29);
            bt_addBook.TabIndex = 1;
            bt_addBook.Text = "Add Book to System";
            bt_addBook.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(312, 211);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 4;
            button1.Text = "View Libraries";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(312, 258);
            button2.Name = "button2";
            button2.Size = new Size(176, 29);
            button2.TabIndex = 5;
            button2.Text = "View Members";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(homePanel);
            Name = "Form1";
            Text = "Form1";
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label introLabel;
        private Panel homePanel;
        private Button bt_addLibrary;
        private Button bt_addBook;
        private Button bt_addMember;
        private Button button1;
        private Button button2;
    }
}
