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
            bt_viewMembers = new Button();
            bt_viewLibraries = new Button();
            bt_addMember = new Button();
            bt_addLibrary = new Button();
            bt_addBook = new Button();
            registerBookPanel = new Panel();
            tb_genre = new TextBox();
            tb_author = new TextBox();
            tb_title = new TextBox();
            bt_addBookSubmit = new Button();
            registerMemberPanel = new Panel();
            tb_name = new TextBox();
            bt_registerMemberSubmit = new Button();
            registerLibraryPanel = new Panel();
            tb_libraryLocation = new TextBox();
            bt_registerLibrarySubmit = new Button();
            viewLibrariesPanel = new Panel();
            libraryViewerFLP = new FlowLayoutPanel();
            placeholderLibraryButton = new Button();
            libraryInfoPanel = new Panel();
            bt_viewCheckedOutBooks = new Button();
            libraryTitleLabel = new Label();
            bt_addLibraryBook = new Button();
            bt_checkoutBook = new Button();
            homePanel.SuspendLayout();
            registerBookPanel.SuspendLayout();
            registerMemberPanel.SuspendLayout();
            registerLibraryPanel.SuspendLayout();
            viewLibrariesPanel.SuspendLayout();
            libraryViewerFLP.SuspendLayout();
            libraryInfoPanel.SuspendLayout();
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
            homePanel.Controls.Add(bt_viewMembers);
            homePanel.Controls.Add(bt_viewLibraries);
            homePanel.Controls.Add(bt_addMember);
            homePanel.Controls.Add(bt_addLibrary);
            homePanel.Controls.Add(bt_addBook);
            homePanel.Controls.Add(introLabel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(800, 451);
            homePanel.TabIndex = 1;
            // 
            // bt_viewMembers
            // 
            bt_viewMembers.BackColor = SystemColors.Desktop;
            bt_viewMembers.ForeColor = SystemColors.ButtonFace;
            bt_viewMembers.Location = new Point(312, 259);
            bt_viewMembers.Name = "bt_viewMembers";
            bt_viewMembers.Size = new Size(176, 29);
            bt_viewMembers.TabIndex = 5;
            bt_viewMembers.Text = "View Members";
            bt_viewMembers.UseVisualStyleBackColor = false;
            // 
            // bt_viewLibraries
            // 
            bt_viewLibraries.BackColor = SystemColors.Desktop;
            bt_viewLibraries.ForeColor = SystemColors.ButtonFace;
            bt_viewLibraries.Location = new Point(312, 211);
            bt_viewLibraries.Name = "bt_viewLibraries";
            bt_viewLibraries.Size = new Size(176, 29);
            bt_viewLibraries.TabIndex = 4;
            bt_viewLibraries.Text = "View Libraries";
            bt_viewLibraries.UseVisualStyleBackColor = false;
            bt_viewLibraries.Click += bt_viewLibraries_Click;
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
            bt_addMember.Click += bt_addMember_Click;
            // 
            // bt_addLibrary
            // 
            bt_addLibrary.BackColor = SystemColors.Desktop;
            bt_addLibrary.ForeColor = SystemColors.ButtonFace;
            bt_addLibrary.Location = new Point(613, 409);
            bt_addLibrary.Name = "bt_addLibrary";
            bt_addLibrary.Size = new Size(176, 29);
            bt_addLibrary.TabIndex = 2;
            bt_addLibrary.Text = "Add Library to System";
            bt_addLibrary.UseVisualStyleBackColor = false;
            bt_addLibrary.Click += bt_addLibrary_Click;
            // 
            // bt_addBook
            // 
            bt_addBook.BackColor = SystemColors.Desktop;
            bt_addBook.ForeColor = SystemColors.ButtonFace;
            bt_addBook.Location = new Point(11, 409);
            bt_addBook.Name = "bt_addBook";
            bt_addBook.Size = new Size(176, 29);
            bt_addBook.TabIndex = 1;
            bt_addBook.Text = "Add Book to System";
            bt_addBook.UseVisualStyleBackColor = false;
            bt_addBook.Click += bt_addBook_Click;
            // 
            // registerBookPanel
            // 
            registerBookPanel.BackColor = SystemColors.Desktop;
            registerBookPanel.Controls.Add(tb_genre);
            registerBookPanel.Controls.Add(tb_author);
            registerBookPanel.Controls.Add(tb_title);
            registerBookPanel.Controls.Add(bt_addBookSubmit);
            registerBookPanel.Dock = DockStyle.Fill;
            registerBookPanel.Location = new Point(0, 0);
            registerBookPanel.Margin = new Padding(3, 4, 3, 4);
            registerBookPanel.Name = "registerBookPanel";
            registerBookPanel.Size = new Size(800, 451);
            registerBookPanel.TabIndex = 6;
            // 
            // tb_genre
            // 
            tb_genre.BackColor = SystemColors.Desktop;
            tb_genre.ForeColor = SystemColors.ButtonFace;
            tb_genre.Location = new Point(326, 247);
            tb_genre.Margin = new Padding(3, 4, 3, 4);
            tb_genre.Name = "tb_genre";
            tb_genre.PlaceholderText = "Genre";
            tb_genre.Size = new Size(114, 27);
            tb_genre.TabIndex = 3;
            // 
            // tb_author
            // 
            tb_author.BackColor = SystemColors.Desktop;
            tb_author.ForeColor = SystemColors.ButtonFace;
            tb_author.Location = new Point(326, 153);
            tb_author.Margin = new Padding(3, 4, 3, 4);
            tb_author.Name = "tb_author";
            tb_author.PlaceholderText = "Author";
            tb_author.Size = new Size(114, 27);
            tb_author.TabIndex = 2;
            // 
            // tb_title
            // 
            tb_title.BackColor = SystemColors.Desktop;
            tb_title.ForeColor = SystemColors.ButtonFace;
            tb_title.Location = new Point(326, 63);
            tb_title.Margin = new Padding(3, 4, 3, 4);
            tb_title.Name = "tb_title";
            tb_title.PlaceholderText = "Title";
            tb_title.Size = new Size(114, 27);
            tb_title.TabIndex = 1;
            // 
            // bt_addBookSubmit
            // 
            bt_addBookSubmit.BackColor = SystemColors.Desktop;
            bt_addBookSubmit.ForeColor = SystemColors.ButtonFace;
            bt_addBookSubmit.Location = new Point(354, 372);
            bt_addBookSubmit.Margin = new Padding(3, 4, 3, 4);
            bt_addBookSubmit.Name = "bt_addBookSubmit";
            bt_addBookSubmit.Size = new Size(86, 31);
            bt_addBookSubmit.TabIndex = 0;
            bt_addBookSubmit.Text = "Add";
            bt_addBookSubmit.UseVisualStyleBackColor = false;
            bt_addBookSubmit.Click += bt_addBookSubmit_Click;
            // 
            // registerMemberPanel
            // 
            registerMemberPanel.BackColor = SystemColors.Desktop;
            registerMemberPanel.Controls.Add(tb_name);
            registerMemberPanel.Controls.Add(bt_registerMemberSubmit);
            registerMemberPanel.Dock = DockStyle.Fill;
            registerMemberPanel.Location = new Point(0, 0);
            registerMemberPanel.Margin = new Padding(3, 4, 3, 4);
            registerMemberPanel.Name = "registerMemberPanel";
            registerMemberPanel.Size = new Size(800, 451);
            registerMemberPanel.TabIndex = 6;
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.Desktop;
            tb_name.ForeColor = SystemColors.ButtonFace;
            tb_name.Location = new Point(336, 173);
            tb_name.Margin = new Padding(3, 4, 3, 4);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Name";
            tb_name.Size = new Size(114, 27);
            tb_name.TabIndex = 1;
            // 
            // bt_registerMemberSubmit
            // 
            bt_registerMemberSubmit.BackColor = SystemColors.Desktop;
            bt_registerMemberSubmit.ForeColor = SystemColors.ButtonFace;
            bt_registerMemberSubmit.Location = new Point(354, 353);
            bt_registerMemberSubmit.Margin = new Padding(3, 4, 3, 4);
            bt_registerMemberSubmit.Name = "bt_registerMemberSubmit";
            bt_registerMemberSubmit.Size = new Size(86, 31);
            bt_registerMemberSubmit.TabIndex = 0;
            bt_registerMemberSubmit.Text = "Register";
            bt_registerMemberSubmit.UseVisualStyleBackColor = false;
            bt_registerMemberSubmit.Click += bt_registerMemberSubmit_Click;
            // 
            // registerLibraryPanel
            // 
            registerLibraryPanel.BackColor = SystemColors.Desktop;
            registerLibraryPanel.Controls.Add(tb_libraryLocation);
            registerLibraryPanel.Controls.Add(bt_registerLibrarySubmit);
            registerLibraryPanel.Dock = DockStyle.Fill;
            registerLibraryPanel.Location = new Point(0, 0);
            registerLibraryPanel.Margin = new Padding(3, 4, 3, 4);
            registerLibraryPanel.Name = "registerLibraryPanel";
            registerLibraryPanel.Size = new Size(800, 451);
            registerLibraryPanel.TabIndex = 6;
            // 
            // tb_libraryLocation
            // 
            tb_libraryLocation.BackColor = SystemColors.Desktop;
            tb_libraryLocation.ForeColor = SystemColors.ButtonFace;
            tb_libraryLocation.Location = new Point(336, 173);
            tb_libraryLocation.Margin = new Padding(3, 4, 3, 4);
            tb_libraryLocation.Name = "tb_libraryLocation";
            tb_libraryLocation.PlaceholderText = "Location";
            tb_libraryLocation.Size = new Size(114, 27);
            tb_libraryLocation.TabIndex = 1;
            // 
            // bt_registerLibrarySubmit
            // 
            bt_registerLibrarySubmit.BackColor = SystemColors.Desktop;
            bt_registerLibrarySubmit.ForeColor = SystemColors.ButtonFace;
            bt_registerLibrarySubmit.Location = new Point(354, 333);
            bt_registerLibrarySubmit.Margin = new Padding(3, 4, 3, 4);
            bt_registerLibrarySubmit.Name = "bt_registerLibrarySubmit";
            bt_registerLibrarySubmit.Size = new Size(86, 31);
            bt_registerLibrarySubmit.TabIndex = 0;
            bt_registerLibrarySubmit.Text = "Register";
            bt_registerLibrarySubmit.UseVisualStyleBackColor = false;
            bt_registerLibrarySubmit.Click += bt_registerLibrarySubmit_Click;
            // 
            // viewLibrariesPanel
            // 
            viewLibrariesPanel.BackColor = SystemColors.Desktop;
            viewLibrariesPanel.Controls.Add(libraryViewerFLP);
            viewLibrariesPanel.Dock = DockStyle.Fill;
            viewLibrariesPanel.Location = new Point(0, 0);
            viewLibrariesPanel.Margin = new Padding(3, 4, 3, 4);
            viewLibrariesPanel.Name = "viewLibrariesPanel";
            viewLibrariesPanel.Size = new Size(800, 451);
            viewLibrariesPanel.TabIndex = 6;
            // 
            // libraryViewerFLP
            // 
            libraryViewerFLP.Controls.Add(placeholderLibraryButton);
            libraryViewerFLP.Location = new Point(14, 16);
            libraryViewerFLP.Margin = new Padding(3, 4, 3, 4);
            libraryViewerFLP.Name = "libraryViewerFLP";
            libraryViewerFLP.Size = new Size(775, 423);
            libraryViewerFLP.TabIndex = 0;
            // 
            // placeholderLibraryButton
            // 
            placeholderLibraryButton.BackColor = SystemColors.Desktop;
            placeholderLibraryButton.ForeColor = SystemColors.ButtonFace;
            placeholderLibraryButton.Location = new Point(3, 4);
            placeholderLibraryButton.Margin = new Padding(3, 4, 3, 4);
            placeholderLibraryButton.Name = "placeholderLibraryButton";
            placeholderLibraryButton.Size = new Size(86, 31);
            placeholderLibraryButton.TabIndex = 0;
            placeholderLibraryButton.Text = "library";
            placeholderLibraryButton.UseVisualStyleBackColor = false;
            placeholderLibraryButton.Visible = false;
            // 
            // libraryInfoPanel
            // 
            libraryInfoPanel.BackColor = SystemColors.Desktop;
            libraryInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            libraryInfoPanel.Controls.Add(bt_checkoutBook);
            libraryInfoPanel.Controls.Add(bt_addLibraryBook);
            libraryInfoPanel.Controls.Add(bt_viewCheckedOutBooks);
            libraryInfoPanel.Controls.Add(libraryTitleLabel);
            libraryInfoPanel.Dock = DockStyle.Fill;
            libraryInfoPanel.Location = new Point(0, 0);
            libraryInfoPanel.Margin = new Padding(3, 4, 3, 4);
            libraryInfoPanel.Name = "libraryInfoPanel";
            libraryInfoPanel.Size = new Size(800, 451);
            libraryInfoPanel.TabIndex = 6;
            // 
            // bt_viewCheckedOutBooks
            // 
            bt_viewCheckedOutBooks.BackColor = SystemColors.Desktop;
            bt_viewCheckedOutBooks.ForeColor = SystemColors.ButtonFace;
            bt_viewCheckedOutBooks.Location = new Point(276, 97);
            bt_viewCheckedOutBooks.Margin = new Padding(3, 4, 3, 4);
            bt_viewCheckedOutBooks.Name = "bt_viewCheckedOutBooks";
            bt_viewCheckedOutBooks.Size = new Size(211, 31);
            bt_viewCheckedOutBooks.TabIndex = 1;
            bt_viewCheckedOutBooks.Text = "View Checked Out Books";
            bt_viewCheckedOutBooks.UseVisualStyleBackColor = false;
            // 
            // libraryTitleLabel
            // 
            libraryTitleLabel.Font = new Font("Segoe UI", 20F);
            libraryTitleLabel.ForeColor = SystemColors.ButtonFace;
            libraryTitleLabel.Location = new Point(221, 8);
            libraryTitleLabel.Name = "libraryTitleLabel";
            libraryTitleLabel.Size = new Size(343, 49);
            libraryTitleLabel.TabIndex = 0;
            libraryTitleLabel.Text = "Library";
            libraryTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            libraryTitleLabel.Visible = false;
            // 
            // bt_addLibraryBook
            // 
            bt_addLibraryBook.BackColor = SystemColors.Desktop;
            bt_addLibraryBook.ForeColor = SystemColors.ButtonFace;
            bt_addLibraryBook.Location = new Point(311, 406);
            bt_addLibraryBook.Margin = new Padding(3, 4, 3, 4);
            bt_addLibraryBook.Name = "bt_addLibraryBook";
            bt_addLibraryBook.Size = new Size(119, 31);
            bt_addLibraryBook.TabIndex = 2;
            bt_addLibraryBook.Text = "Add Book";
            bt_addLibraryBook.UseVisualStyleBackColor = false;
            // 
            // bt_checkoutBook
            // 
            bt_checkoutBook.BackColor = SystemColors.Desktop;
            bt_checkoutBook.ForeColor = SystemColors.ButtonFace;
            bt_checkoutBook.Location = new Point(612, 406);
            bt_checkoutBook.Margin = new Padding(3, 4, 3, 4);
            bt_checkoutBook.Name = "bt_checkoutBook";
            bt_checkoutBook.Size = new Size(119, 31);
            bt_checkoutBook.TabIndex = 3;
            bt_checkoutBook.Text = "Checkout Book";
            bt_checkoutBook.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(libraryInfoPanel);
            Controls.Add(homePanel);
            Controls.Add(registerBookPanel);
            Controls.Add(registerMemberPanel);
            Controls.Add(registerLibraryPanel);
            Controls.Add(viewLibrariesPanel);
            Name = "Form1";
            Text = "Form1";
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            registerBookPanel.ResumeLayout(false);
            registerBookPanel.PerformLayout();
            registerMemberPanel.ResumeLayout(false);
            registerMemberPanel.PerformLayout();
            registerLibraryPanel.ResumeLayout(false);
            registerLibraryPanel.PerformLayout();
            viewLibrariesPanel.ResumeLayout(false);
            libraryViewerFLP.ResumeLayout(false);
            libraryInfoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label introLabel;
        private Panel homePanel;
        private Button bt_addLibrary;
        private Button bt_addBook;
        private Button bt_addMember;
        private Button bt_viewLibraries;
        private Button bt_viewMembers;
        private Panel registerBookPanel;
        private TextBox tb_genre;
        private TextBox tb_author;
        private TextBox tb_title;
        private Button bt_addBookSubmit;
        private Panel registerMemberPanel;
        private TextBox tb_name;
        private Button bt_registerMemberSubmit;
        private Panel registerLibraryPanel;
        private TextBox tb_libraryLocation;
        private Button bt_registerLibrarySubmit;
        private Panel viewLibrariesPanel;
        private FlowLayoutPanel libraryViewerFLP;
        private Button placeholderLibraryButton;
        private Panel libraryInfoPanel;
        private Label libraryTitleLabel;
        private Button bt_viewCheckedOutBooks;
        private Button bt_checkoutBook;
        private Button bt_addLibraryBook;
    }
}
