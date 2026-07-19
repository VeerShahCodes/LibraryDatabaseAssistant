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
            bt_checkoutBook = new Button();
            bt_addLibraryBook = new Button();
            bt_viewCheckedOutBooks = new Button();
            libraryTitleLabel = new Label();
            viewMembersPanel = new Panel();
            memberViewerFLP = new FlowLayoutPanel();
            memberInfoPanel = new Panel();
            memberNameLabel = new Label();
            addBookToLibraryPanel = new Panel();
            booksToAddToLibraryFLP = new FlowLayoutPanel();
            checkoutBookPanel = new Panel();
            bt_confirmCheckout = new Button();
            memberCheckoutFLP = new FlowLayoutPanel();
            bookCheckoutFLP = new FlowLayoutPanel();
            viewLibraryCheckedOutBooksPanel = new Panel();
            l_checkedOutBooksTLP = new TableLayoutPanel();
            homePanel.SuspendLayout();
            registerBookPanel.SuspendLayout();
            registerMemberPanel.SuspendLayout();
            registerLibraryPanel.SuspendLayout();
            viewLibrariesPanel.SuspendLayout();
            libraryViewerFLP.SuspendLayout();
            libraryInfoPanel.SuspendLayout();
            viewMembersPanel.SuspendLayout();
            memberInfoPanel.SuspendLayout();
            addBookToLibraryPanel.SuspendLayout();
            checkoutBookPanel.SuspendLayout();
            viewLibraryCheckedOutBooksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // introLabel
            // 
            introLabel.AutoSize = true;
            introLabel.Font = new Font("Segoe UI", 20F);
            introLabel.ForeColor = SystemColors.ButtonFace;
            introLabel.Location = new Point(114, 7);
            introLabel.Name = "introLabel";
            introLabel.Size = new Size(403, 37);
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
            homePanel.Margin = new Padding(3, 2, 3, 2);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(700, 338);
            homePanel.TabIndex = 1;
            // 
            // bt_viewMembers
            // 
            bt_viewMembers.BackColor = SystemColors.Desktop;
            bt_viewMembers.ForeColor = SystemColors.ButtonFace;
            bt_viewMembers.Location = new Point(273, 194);
            bt_viewMembers.Margin = new Padding(3, 2, 3, 2);
            bt_viewMembers.Name = "bt_viewMembers";
            bt_viewMembers.Size = new Size(154, 22);
            bt_viewMembers.TabIndex = 5;
            bt_viewMembers.Text = "View Members";
            bt_viewMembers.UseVisualStyleBackColor = false;
            bt_viewMembers.Click += bt_viewMembers_Click;
            // 
            // bt_viewLibraries
            // 
            bt_viewLibraries.BackColor = SystemColors.Desktop;
            bt_viewLibraries.ForeColor = SystemColors.ButtonFace;
            bt_viewLibraries.Location = new Point(273, 158);
            bt_viewLibraries.Margin = new Padding(3, 2, 3, 2);
            bt_viewLibraries.Name = "bt_viewLibraries";
            bt_viewLibraries.Size = new Size(154, 22);
            bt_viewLibraries.TabIndex = 4;
            bt_viewLibraries.Text = "View Libraries";
            bt_viewLibraries.UseVisualStyleBackColor = false;
            bt_viewLibraries.Click += bt_viewLibraries_Click;
            // 
            // bt_addMember
            // 
            bt_addMember.BackColor = SystemColors.Desktop;
            bt_addMember.ForeColor = SystemColors.ButtonFace;
            bt_addMember.Location = new Point(273, 307);
            bt_addMember.Margin = new Padding(3, 2, 3, 2);
            bt_addMember.Name = "bt_addMember";
            bt_addMember.Size = new Size(154, 22);
            bt_addMember.TabIndex = 3;
            bt_addMember.Text = "Register Member";
            bt_addMember.UseVisualStyleBackColor = false;
            bt_addMember.Click += bt_addMember_Click;
            // 
            // bt_addLibrary
            // 
            bt_addLibrary.BackColor = SystemColors.Desktop;
            bt_addLibrary.ForeColor = SystemColors.ButtonFace;
            bt_addLibrary.Location = new Point(536, 307);
            bt_addLibrary.Margin = new Padding(3, 2, 3, 2);
            bt_addLibrary.Name = "bt_addLibrary";
            bt_addLibrary.Size = new Size(154, 22);
            bt_addLibrary.TabIndex = 2;
            bt_addLibrary.Text = "Add Library to System";
            bt_addLibrary.UseVisualStyleBackColor = false;
            bt_addLibrary.Click += bt_addLibrary_Click;
            // 
            // bt_addBook
            // 
            bt_addBook.BackColor = SystemColors.Desktop;
            bt_addBook.ForeColor = SystemColors.ButtonFace;
            bt_addBook.Location = new Point(10, 307);
            bt_addBook.Margin = new Padding(3, 2, 3, 2);
            bt_addBook.Name = "bt_addBook";
            bt_addBook.Size = new Size(154, 22);
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
            registerBookPanel.Name = "registerBookPanel";
            registerBookPanel.Size = new Size(700, 338);
            registerBookPanel.TabIndex = 6;
            // 
            // tb_genre
            // 
            tb_genre.BackColor = SystemColors.Desktop;
            tb_genre.ForeColor = SystemColors.ButtonFace;
            tb_genre.Location = new Point(285, 185);
            tb_genre.Name = "tb_genre";
            tb_genre.PlaceholderText = "Genre";
            tb_genre.Size = new Size(100, 23);
            tb_genre.TabIndex = 3;
            // 
            // tb_author
            // 
            tb_author.BackColor = SystemColors.Desktop;
            tb_author.ForeColor = SystemColors.ButtonFace;
            tb_author.Location = new Point(285, 115);
            tb_author.Name = "tb_author";
            tb_author.PlaceholderText = "Author";
            tb_author.Size = new Size(100, 23);
            tb_author.TabIndex = 2;
            // 
            // tb_title
            // 
            tb_title.BackColor = SystemColors.Desktop;
            tb_title.ForeColor = SystemColors.ButtonFace;
            tb_title.Location = new Point(285, 47);
            tb_title.Name = "tb_title";
            tb_title.PlaceholderText = "Title";
            tb_title.Size = new Size(100, 23);
            tb_title.TabIndex = 1;
            // 
            // bt_addBookSubmit
            // 
            bt_addBookSubmit.BackColor = SystemColors.Desktop;
            bt_addBookSubmit.ForeColor = SystemColors.ButtonFace;
            bt_addBookSubmit.Location = new Point(310, 279);
            bt_addBookSubmit.Name = "bt_addBookSubmit";
            bt_addBookSubmit.Size = new Size(75, 23);
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
            registerMemberPanel.Name = "registerMemberPanel";
            registerMemberPanel.Size = new Size(700, 338);
            registerMemberPanel.TabIndex = 6;
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.Desktop;
            tb_name.ForeColor = SystemColors.ButtonFace;
            tb_name.Location = new Point(294, 130);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Name";
            tb_name.Size = new Size(100, 23);
            tb_name.TabIndex = 1;
            // 
            // bt_registerMemberSubmit
            // 
            bt_registerMemberSubmit.BackColor = SystemColors.Desktop;
            bt_registerMemberSubmit.ForeColor = SystemColors.ButtonFace;
            bt_registerMemberSubmit.Location = new Point(310, 265);
            bt_registerMemberSubmit.Name = "bt_registerMemberSubmit";
            bt_registerMemberSubmit.Size = new Size(75, 23);
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
            registerLibraryPanel.Name = "registerLibraryPanel";
            registerLibraryPanel.Size = new Size(700, 338);
            registerLibraryPanel.TabIndex = 6;
            // 
            // tb_libraryLocation
            // 
            tb_libraryLocation.BackColor = SystemColors.Desktop;
            tb_libraryLocation.ForeColor = SystemColors.ButtonFace;
            tb_libraryLocation.Location = new Point(294, 130);
            tb_libraryLocation.Name = "tb_libraryLocation";
            tb_libraryLocation.PlaceholderText = "Location";
            tb_libraryLocation.Size = new Size(100, 23);
            tb_libraryLocation.TabIndex = 1;
            // 
            // bt_registerLibrarySubmit
            // 
            bt_registerLibrarySubmit.BackColor = SystemColors.Desktop;
            bt_registerLibrarySubmit.ForeColor = SystemColors.ButtonFace;
            bt_registerLibrarySubmit.Location = new Point(310, 250);
            bt_registerLibrarySubmit.Name = "bt_registerLibrarySubmit";
            bt_registerLibrarySubmit.Size = new Size(75, 23);
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
            viewLibrariesPanel.Name = "viewLibrariesPanel";
            viewLibrariesPanel.Size = new Size(700, 338);
            viewLibrariesPanel.TabIndex = 6;
            // 
            // libraryViewerFLP
            // 
            libraryViewerFLP.Controls.Add(placeholderLibraryButton);
            libraryViewerFLP.Location = new Point(12, 12);
            libraryViewerFLP.Name = "libraryViewerFLP";
            libraryViewerFLP.Size = new Size(678, 317);
            libraryViewerFLP.TabIndex = 0;
            // 
            // placeholderLibraryButton
            // 
            placeholderLibraryButton.BackColor = SystemColors.Desktop;
            placeholderLibraryButton.ForeColor = SystemColors.ButtonFace;
            placeholderLibraryButton.Location = new Point(3, 3);
            placeholderLibraryButton.Name = "placeholderLibraryButton";
            placeholderLibraryButton.Size = new Size(75, 23);
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
            libraryInfoPanel.Name = "libraryInfoPanel";
            libraryInfoPanel.Size = new Size(700, 338);
            libraryInfoPanel.TabIndex = 6;
            // 
            // bt_checkoutBook
            // 
            bt_checkoutBook.BackColor = SystemColors.Desktop;
            bt_checkoutBook.ForeColor = SystemColors.ButtonFace;
            bt_checkoutBook.Location = new Point(536, 304);
            bt_checkoutBook.Name = "bt_checkoutBook";
            bt_checkoutBook.Size = new Size(104, 23);
            bt_checkoutBook.TabIndex = 3;
            bt_checkoutBook.Text = "Checkout Book";
            bt_checkoutBook.UseVisualStyleBackColor = false;
            bt_checkoutBook.Click += bt_checkoutBook_Click;
            // 
            // bt_addLibraryBook
            // 
            bt_addLibraryBook.BackColor = SystemColors.Desktop;
            bt_addLibraryBook.ForeColor = SystemColors.ButtonFace;
            bt_addLibraryBook.Location = new Point(272, 304);
            bt_addLibraryBook.Name = "bt_addLibraryBook";
            bt_addLibraryBook.Size = new Size(104, 23);
            bt_addLibraryBook.TabIndex = 2;
            bt_addLibraryBook.Text = "Add Book";
            bt_addLibraryBook.UseVisualStyleBackColor = false;
            bt_addLibraryBook.Click += bt_addLibraryBook_Click;
            // 
            // bt_viewCheckedOutBooks
            // 
            bt_viewCheckedOutBooks.BackColor = SystemColors.Desktop;
            bt_viewCheckedOutBooks.ForeColor = SystemColors.ButtonFace;
            bt_viewCheckedOutBooks.Location = new Point(242, 73);
            bt_viewCheckedOutBooks.Name = "bt_viewCheckedOutBooks";
            bt_viewCheckedOutBooks.Size = new Size(185, 23);
            bt_viewCheckedOutBooks.TabIndex = 1;
            bt_viewCheckedOutBooks.Text = "View Checked Out Books";
            bt_viewCheckedOutBooks.UseVisualStyleBackColor = false;
            bt_viewCheckedOutBooks.Click += bt_viewCheckedOutBooks_Click;
            // 
            // libraryTitleLabel
            // 
            libraryTitleLabel.Font = new Font("Segoe UI", 20F);
            libraryTitleLabel.ForeColor = SystemColors.ButtonFace;
            libraryTitleLabel.Location = new Point(193, 6);
            libraryTitleLabel.Name = "libraryTitleLabel";
            libraryTitleLabel.Size = new Size(300, 37);
            libraryTitleLabel.TabIndex = 0;
            libraryTitleLabel.Text = "Library";
            libraryTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            libraryTitleLabel.Visible = false;
            // 
            // viewMembersPanel
            // 
            viewMembersPanel.BackColor = SystemColors.Desktop;
            viewMembersPanel.Controls.Add(memberViewerFLP);
            viewMembersPanel.Dock = DockStyle.Fill;
            viewMembersPanel.Location = new Point(0, 0);
            viewMembersPanel.Margin = new Padding(3, 2, 3, 2);
            viewMembersPanel.Name = "viewMembersPanel";
            viewMembersPanel.Size = new Size(700, 338);
            viewMembersPanel.TabIndex = 6;
            // 
            // memberViewerFLP
            // 
            memberViewerFLP.Location = new Point(32, 15);
            memberViewerFLP.Margin = new Padding(3, 2, 3, 2);
            memberViewerFLP.Name = "memberViewerFLP";
            memberViewerFLP.Size = new Size(640, 297);
            memberViewerFLP.TabIndex = 0;
            // 
            // memberInfoPanel
            // 
            memberInfoPanel.BackColor = SystemColors.Desktop;
            memberInfoPanel.Controls.Add(memberNameLabel);
            memberInfoPanel.Dock = DockStyle.Fill;
            memberInfoPanel.Location = new Point(0, 0);
            memberInfoPanel.Margin = new Padding(3, 2, 3, 2);
            memberInfoPanel.Name = "memberInfoPanel";
            memberInfoPanel.Size = new Size(700, 338);
            memberInfoPanel.TabIndex = 1;
            // 
            // memberNameLabel
            // 
            memberNameLabel.AutoSize = true;
            memberNameLabel.Font = new Font("Segoe UI", 20F);
            memberNameLabel.ForeColor = SystemColors.ButtonFace;
            memberNameLabel.Location = new Point(298, 12);
            memberNameLabel.Name = "memberNameLabel";
            memberNameLabel.Size = new Size(88, 37);
            memberNameLabel.TabIndex = 0;
            memberNameLabel.Text = "Name";
            memberNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addBookToLibraryPanel
            // 
            addBookToLibraryPanel.BackColor = SystemColors.Desktop;
            addBookToLibraryPanel.Controls.Add(booksToAddToLibraryFLP);
            addBookToLibraryPanel.Dock = DockStyle.Fill;
            addBookToLibraryPanel.Location = new Point(0, 0);
            addBookToLibraryPanel.Name = "addBookToLibraryPanel";
            addBookToLibraryPanel.Size = new Size(700, 338);
            addBookToLibraryPanel.TabIndex = 4;
            // 
            // booksToAddToLibraryFLP
            // 
            booksToAddToLibraryFLP.Location = new Point(49, 29);
            booksToAddToLibraryFLP.Name = "booksToAddToLibraryFLP";
            booksToAddToLibraryFLP.Size = new Size(592, 283);
            booksToAddToLibraryFLP.TabIndex = 0;
            // 
            // checkoutBookPanel
            // 
            checkoutBookPanel.BackColor = SystemColors.Desktop;
            checkoutBookPanel.Controls.Add(bt_confirmCheckout);
            checkoutBookPanel.Controls.Add(memberCheckoutFLP);
            checkoutBookPanel.Controls.Add(bookCheckoutFLP);
            checkoutBookPanel.Dock = DockStyle.Fill;
            checkoutBookPanel.Location = new Point(0, 0);
            checkoutBookPanel.Name = "checkoutBookPanel";
            checkoutBookPanel.Size = new Size(700, 338);
            checkoutBookPanel.TabIndex = 1;
            // 
            // bt_confirmCheckout
            // 
            bt_confirmCheckout.BackColor = SystemColors.Desktop;
            bt_confirmCheckout.ForeColor = SystemColors.ButtonFace;
            bt_confirmCheckout.Location = new Point(613, 130);
            bt_confirmCheckout.Name = "bt_confirmCheckout";
            bt_confirmCheckout.Size = new Size(75, 23);
            bt_confirmCheckout.TabIndex = 2;
            bt_confirmCheckout.Text = "Confirm";
            bt_confirmCheckout.UseVisualStyleBackColor = false;
            bt_confirmCheckout.Click += bt_confirmCheckout_Click;
            // 
            // memberCheckoutFLP
            // 
            memberCheckoutFLP.Location = new Point(308, 19);
            memberCheckoutFLP.Name = "memberCheckoutFLP";
            memberCheckoutFLP.Size = new Size(277, 307);
            memberCheckoutFLP.TabIndex = 1;
            // 
            // bookCheckoutFLP
            // 
            bookCheckoutFLP.Location = new Point(15, 15);
            bookCheckoutFLP.Name = "bookCheckoutFLP";
            bookCheckoutFLP.Size = new Size(277, 311);
            bookCheckoutFLP.TabIndex = 0;
            // 
            // viewLibraryCheckedOutBooksPanel
            // 
            viewLibraryCheckedOutBooksPanel.BackColor = SystemColors.Desktop;
            viewLibraryCheckedOutBooksPanel.Controls.Add(l_checkedOutBooksTLP);
            viewLibraryCheckedOutBooksPanel.Dock = DockStyle.Fill;
            viewLibraryCheckedOutBooksPanel.Location = new Point(0, 0);
            viewLibraryCheckedOutBooksPanel.Name = "viewLibraryCheckedOutBooksPanel";
            viewLibraryCheckedOutBooksPanel.Size = new Size(700, 338);
            viewLibraryCheckedOutBooksPanel.TabIndex = 4;
            // 
            // l_checkedOutBooksTLP
            // 
            l_checkedOutBooksTLP.ColumnCount = 4;
            l_checkedOutBooksTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            l_checkedOutBooksTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            l_checkedOutBooksTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            l_checkedOutBooksTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            l_checkedOutBooksTLP.Location = new Point(32, 19);
            l_checkedOutBooksTLP.Name = "l_checkedOutBooksTLP";
            l_checkedOutBooksTLP.RowCount = 20;
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            l_checkedOutBooksTLP.Size = new Size(635, 300);
            l_checkedOutBooksTLP.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(viewLibraryCheckedOutBooksPanel);
            Controls.Add(libraryInfoPanel);
            Controls.Add(memberInfoPanel);
            Controls.Add(viewMembersPanel);
            Controls.Add(homePanel);
            Controls.Add(registerBookPanel);
            Controls.Add(registerMemberPanel);
            Controls.Add(registerLibraryPanel);
            Controls.Add(viewLibrariesPanel);
            Controls.Add(checkoutBookPanel);
            Controls.Add(addBookToLibraryPanel);
            Margin = new Padding(3, 2, 3, 2);
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
            viewMembersPanel.ResumeLayout(false);
            memberInfoPanel.ResumeLayout(false);
            memberInfoPanel.PerformLayout();
            addBookToLibraryPanel.ResumeLayout(false);
            checkoutBookPanel.ResumeLayout(false);
            viewLibraryCheckedOutBooksPanel.ResumeLayout(false);
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
        private Panel viewMembersPanel;
        private FlowLayoutPanel memberViewerFLP;
        private Panel memberInfoPanel;
        private Label memberNameLabel;
        private Panel addBookToLibraryPanel;
        private FlowLayoutPanel booksToAddToLibraryFLP;
        private Panel checkoutBookPanel;
        private Button bt_confirmCheckout;
        private FlowLayoutPanel memberCheckoutFLP;
        private FlowLayoutPanel bookCheckoutFLP;
        private Panel viewLibraryCheckedOutBooksPanel;
        private TableLayoutPanel l_checkedOutBooksTLP;
    }
}
