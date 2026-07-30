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
            bt_memberCheckoutBook = new Button();
            bt_returnBook = new Button();
            bt_viewMemberBooks = new Button();
            memberNameLabel = new Label();
            addBookToLibraryPanel = new Panel();
            booksToAddToLibraryFLP = new FlowLayoutPanel();
            checkoutBookPanel = new Panel();
            bt_confirmCheckout = new Button();
            memberCheckoutFLP = new FlowLayoutPanel();
            bookCheckoutFLP = new FlowLayoutPanel();
            viewLibraryCheckedOutBooksPanel = new Panel();
            checkedOutBookDisplay = new Panel();
            timeLabel = new Label();
            libraryLabel = new Label();
            titleLabel = new Label();
            memberLabel = new Label();
            viewMemberCheckedOutBooksPanel = new Panel();
            memberCheckedOutBooksDisplay = new Panel();
            timeLabelTwo = new Label();
            bookLabelTwo = new Label();
            libraryLabelTwo = new Label();
            memberLabel2 = new Label();
            memberReturnBookPanel = new Panel();
            bt_returnBookMemberSubmit = new Button();
            returnLibraryMemberChoiceFLP = new FlowLayoutPanel();
            returnBookMemberChoiceFLP = new FlowLayoutPanel();
            bt_goBack = new Button();
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
            checkedOutBookDisplay.SuspendLayout();
            viewMemberCheckedOutBooksPanel.SuspendLayout();
            memberCheckedOutBooksDisplay.SuspendLayout();
            memberReturnBookPanel.SuspendLayout();
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
            bt_viewMembers.Click += bt_viewMembers_Click;
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
            registerBookPanel.Tag = "homePanel";
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
            registerMemberPanel.Tag = "homePanel";
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
            registerLibraryPanel.Tag = "homePanel";
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
            viewLibrariesPanel.Tag = "homePanel";
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
            libraryInfoPanel.Tag = "viewLibrariesPanel";
            // 
            // bt_checkoutBook
            // 
            bt_checkoutBook.BackColor = SystemColors.Desktop;
            bt_checkoutBook.ForeColor = SystemColors.ButtonFace;
            bt_checkoutBook.Location = new Point(613, 405);
            bt_checkoutBook.Margin = new Padding(3, 4, 3, 4);
            bt_checkoutBook.Name = "bt_checkoutBook";
            bt_checkoutBook.Size = new Size(119, 31);
            bt_checkoutBook.TabIndex = 3;
            bt_checkoutBook.Text = "Checkout Book";
            bt_checkoutBook.UseVisualStyleBackColor = false;
            bt_checkoutBook.Click += bt_checkoutBook_Click;
            // 
            // bt_addLibraryBook
            // 
            bt_addLibraryBook.BackColor = SystemColors.Desktop;
            bt_addLibraryBook.ForeColor = SystemColors.ButtonFace;
            bt_addLibraryBook.Location = new Point(311, 405);
            bt_addLibraryBook.Margin = new Padding(3, 4, 3, 4);
            bt_addLibraryBook.Name = "bt_addLibraryBook";
            bt_addLibraryBook.Size = new Size(119, 31);
            bt_addLibraryBook.TabIndex = 2;
            bt_addLibraryBook.Text = "Add Book";
            bt_addLibraryBook.UseVisualStyleBackColor = false;
            bt_addLibraryBook.Click += bt_addLibraryBook_Click;
            // 
            // bt_viewCheckedOutBooks
            // 
            bt_viewCheckedOutBooks.BackColor = SystemColors.Desktop;
            bt_viewCheckedOutBooks.ForeColor = SystemColors.ButtonFace;
            bt_viewCheckedOutBooks.Location = new Point(277, 97);
            bt_viewCheckedOutBooks.Margin = new Padding(3, 4, 3, 4);
            bt_viewCheckedOutBooks.Name = "bt_viewCheckedOutBooks";
            bt_viewCheckedOutBooks.Size = new Size(211, 31);
            bt_viewCheckedOutBooks.TabIndex = 1;
            bt_viewCheckedOutBooks.Text = "View Checked Out Books";
            bt_viewCheckedOutBooks.UseVisualStyleBackColor = false;
            bt_viewCheckedOutBooks.Click += bt_viewCheckedOutBooks_Click;
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
            // viewMembersPanel
            // 
            viewMembersPanel.BackColor = SystemColors.Desktop;
            viewMembersPanel.Controls.Add(memberViewerFLP);
            viewMembersPanel.Dock = DockStyle.Fill;
            viewMembersPanel.Location = new Point(0, 0);
            viewMembersPanel.Name = "viewMembersPanel";
            viewMembersPanel.Size = new Size(800, 451);
            viewMembersPanel.TabIndex = 6;
            // 
            // memberViewerFLP
            // 
            memberViewerFLP.Location = new Point(37, 20);
            memberViewerFLP.Name = "memberViewerFLP";
            memberViewerFLP.Size = new Size(731, 396);
            memberViewerFLP.TabIndex = 0;
            // 
            // memberInfoPanel
            // 
            memberInfoPanel.BackColor = SystemColors.Desktop;
            memberInfoPanel.Controls.Add(bt_memberCheckoutBook);
            memberInfoPanel.Controls.Add(bt_returnBook);
            memberInfoPanel.Controls.Add(bt_viewMemberBooks);
            memberInfoPanel.Controls.Add(memberNameLabel);
            memberInfoPanel.Dock = DockStyle.Fill;
            memberInfoPanel.Location = new Point(0, 0);
            memberInfoPanel.Name = "memberInfoPanel";
            memberInfoPanel.Size = new Size(800, 451);
            memberInfoPanel.TabIndex = 1;
            memberInfoPanel.Tag = "viewMembersPanel";
            // 
            // bt_memberCheckoutBook
            // 
            bt_memberCheckoutBook.BackColor = SystemColors.Desktop;
            bt_memberCheckoutBook.ForeColor = SystemColors.ButtonFace;
            bt_memberCheckoutBook.Location = new Point(312, 209);
            bt_memberCheckoutBook.Margin = new Padding(3, 4, 3, 4);
            bt_memberCheckoutBook.Name = "bt_memberCheckoutBook";
            bt_memberCheckoutBook.Size = new Size(143, 31);
            bt_memberCheckoutBook.TabIndex = 3;
            bt_memberCheckoutBook.Text = "Checkout Book";
            bt_memberCheckoutBook.UseVisualStyleBackColor = false;
            bt_memberCheckoutBook.Click += bt_memberCheckoutBook_Click;
            // 
            // bt_returnBook
            // 
            bt_returnBook.BackColor = SystemColors.Desktop;
            bt_returnBook.ForeColor = SystemColors.ButtonFace;
            bt_returnBook.Location = new Point(326, 152);
            bt_returnBook.Margin = new Padding(3, 4, 3, 4);
            bt_returnBook.Name = "bt_returnBook";
            bt_returnBook.Size = new Size(122, 31);
            bt_returnBook.TabIndex = 2;
            bt_returnBook.Text = "Return Book";
            bt_returnBook.UseVisualStyleBackColor = false;
            bt_returnBook.Click += bt_returnBook_Click;
            // 
            // bt_viewMemberBooks
            // 
            bt_viewMemberBooks.BackColor = SystemColors.Desktop;
            bt_viewMemberBooks.ForeColor = SystemColors.ButtonFace;
            bt_viewMemberBooks.Location = new Point(296, 99);
            bt_viewMemberBooks.Margin = new Padding(3, 4, 3, 4);
            bt_viewMemberBooks.Name = "bt_viewMemberBooks";
            bt_viewMemberBooks.Size = new Size(171, 31);
            bt_viewMemberBooks.TabIndex = 1;
            bt_viewMemberBooks.Text = "View Checked Out Books";
            bt_viewMemberBooks.UseVisualStyleBackColor = false;
            bt_viewMemberBooks.Click += bt_viewMemberBooks_Click;
            // 
            // memberNameLabel
            // 
            memberNameLabel.AutoSize = true;
            memberNameLabel.Font = new Font("Segoe UI", 20F);
            memberNameLabel.ForeColor = SystemColors.ButtonFace;
            memberNameLabel.Location = new Point(341, 16);
            memberNameLabel.Name = "memberNameLabel";
            memberNameLabel.Size = new Size(109, 46);
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
            addBookToLibraryPanel.Margin = new Padding(3, 4, 3, 4);
            addBookToLibraryPanel.Name = "addBookToLibraryPanel";
            addBookToLibraryPanel.Size = new Size(800, 451);
            addBookToLibraryPanel.TabIndex = 4;
            addBookToLibraryPanel.Tag = "libraryInfoPanel";
            // 
            // booksToAddToLibraryFLP
            // 
            booksToAddToLibraryFLP.Location = new Point(56, 39);
            booksToAddToLibraryFLP.Margin = new Padding(3, 4, 3, 4);
            booksToAddToLibraryFLP.Name = "booksToAddToLibraryFLP";
            booksToAddToLibraryFLP.Size = new Size(677, 377);
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
            checkoutBookPanel.Margin = new Padding(3, 4, 3, 4);
            checkoutBookPanel.Name = "checkoutBookPanel";
            checkoutBookPanel.Size = new Size(800, 451);
            checkoutBookPanel.TabIndex = 1;
            checkoutBookPanel.Tag = "libraryInfoPanel";
            // 
            // bt_confirmCheckout
            // 
            bt_confirmCheckout.BackColor = SystemColors.Desktop;
            bt_confirmCheckout.ForeColor = SystemColors.ButtonFace;
            bt_confirmCheckout.Location = new Point(701, 173);
            bt_confirmCheckout.Margin = new Padding(3, 4, 3, 4);
            bt_confirmCheckout.Name = "bt_confirmCheckout";
            bt_confirmCheckout.Size = new Size(86, 31);
            bt_confirmCheckout.TabIndex = 2;
            bt_confirmCheckout.Text = "Confirm";
            bt_confirmCheckout.UseVisualStyleBackColor = false;
            bt_confirmCheckout.Click += bt_confirmCheckout_Click;
            // 
            // memberCheckoutFLP
            // 
            memberCheckoutFLP.Location = new Point(352, 25);
            memberCheckoutFLP.Margin = new Padding(3, 4, 3, 4);
            memberCheckoutFLP.Name = "memberCheckoutFLP";
            memberCheckoutFLP.Size = new Size(317, 409);
            memberCheckoutFLP.TabIndex = 1;
            // 
            // bookCheckoutFLP
            // 
            bookCheckoutFLP.Location = new Point(17, 20);
            bookCheckoutFLP.Margin = new Padding(3, 4, 3, 4);
            bookCheckoutFLP.Name = "bookCheckoutFLP";
            bookCheckoutFLP.Size = new Size(317, 415);
            bookCheckoutFLP.TabIndex = 0;
            // 
            // viewLibraryCheckedOutBooksPanel
            // 
            viewLibraryCheckedOutBooksPanel.BackColor = SystemColors.Desktop;
            viewLibraryCheckedOutBooksPanel.Controls.Add(checkedOutBookDisplay);
            viewLibraryCheckedOutBooksPanel.Dock = DockStyle.Fill;
            viewLibraryCheckedOutBooksPanel.Location = new Point(0, 0);
            viewLibraryCheckedOutBooksPanel.Margin = new Padding(3, 4, 3, 4);
            viewLibraryCheckedOutBooksPanel.Name = "viewLibraryCheckedOutBooksPanel";
            viewLibraryCheckedOutBooksPanel.Size = new Size(800, 451);
            viewLibraryCheckedOutBooksPanel.TabIndex = 4;
            viewLibraryCheckedOutBooksPanel.Tag = "libraryInfoPanel";
            // 
            // checkedOutBookDisplay
            // 
            checkedOutBookDisplay.Controls.Add(timeLabel);
            checkedOutBookDisplay.Controls.Add(libraryLabel);
            checkedOutBookDisplay.Controls.Add(titleLabel);
            checkedOutBookDisplay.Controls.Add(memberLabel);
            checkedOutBookDisplay.Location = new Point(46, 27);
            checkedOutBookDisplay.Name = "checkedOutBookDisplay";
            checkedOutBookDisplay.Size = new Size(722, 409);
            checkedOutBookDisplay.TabIndex = 0;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.ForeColor = SystemColors.ButtonFace;
            timeLabel.Location = new Point(525, 16);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(125, 20);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time of Checkout";
            // 
            // libraryLabel
            // 
            libraryLabel.AutoSize = true;
            libraryLabel.ForeColor = SystemColors.ButtonFace;
            libraryLabel.Location = new Point(347, 16);
            libraryLabel.Name = "libraryLabel";
            libraryLabel.Size = new Size(54, 20);
            libraryLabel.TabIndex = 2;
            libraryLabel.Text = "Library";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = SystemColors.ButtonFace;
            titleLabel.Location = new Point(197, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(38, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // memberLabel
            // 
            memberLabel.AutoSize = true;
            memberLabel.ForeColor = SystemColors.ButtonFace;
            memberLabel.Location = new Point(45, 16);
            memberLabel.Name = "memberLabel";
            memberLabel.Size = new Size(65, 20);
            memberLabel.TabIndex = 0;
            memberLabel.Text = "Member";
            // 
            // viewMemberCheckedOutBooksPanel
            // 
            viewMemberCheckedOutBooksPanel.BackColor = SystemColors.Desktop;
            viewMemberCheckedOutBooksPanel.Controls.Add(memberCheckedOutBooksDisplay);
            viewMemberCheckedOutBooksPanel.Dock = DockStyle.Fill;
            viewMemberCheckedOutBooksPanel.Location = new Point(0, 0);
            viewMemberCheckedOutBooksPanel.Margin = new Padding(3, 4, 3, 4);
            viewMemberCheckedOutBooksPanel.Name = "viewMemberCheckedOutBooksPanel";
            viewMemberCheckedOutBooksPanel.Size = new Size(800, 451);
            viewMemberCheckedOutBooksPanel.TabIndex = 4;
            viewMemberCheckedOutBooksPanel.Tag = "memberInfoPanel";
            // 
            // memberCheckedOutBooksDisplay
            // 
            memberCheckedOutBooksDisplay.Controls.Add(timeLabelTwo);
            memberCheckedOutBooksDisplay.Controls.Add(bookLabelTwo);
            memberCheckedOutBooksDisplay.Controls.Add(libraryLabelTwo);
            memberCheckedOutBooksDisplay.Controls.Add(memberLabel2);
            memberCheckedOutBooksDisplay.Location = new Point(25, 25);
            memberCheckedOutBooksDisplay.Margin = new Padding(3, 4, 3, 4);
            memberCheckedOutBooksDisplay.Name = "memberCheckedOutBooksDisplay";
            memberCheckedOutBooksDisplay.Size = new Size(743, 413);
            memberCheckedOutBooksDisplay.TabIndex = 0;
            // 
            // timeLabelTwo
            // 
            timeLabelTwo.AutoSize = true;
            timeLabelTwo.ForeColor = SystemColors.ButtonFace;
            timeLabelTwo.Location = new Point(546, 24);
            timeLabelTwo.Name = "timeLabelTwo";
            timeLabelTwo.Size = new Size(125, 20);
            timeLabelTwo.TabIndex = 3;
            timeLabelTwo.Text = "Time of Checkout";
            // 
            // bookLabelTwo
            // 
            bookLabelTwo.AutoSize = true;
            bookLabelTwo.ForeColor = SystemColors.ButtonFace;
            bookLabelTwo.Location = new Point(403, 24);
            bookLabelTwo.Name = "bookLabelTwo";
            bookLabelTwo.Size = new Size(43, 20);
            bookLabelTwo.TabIndex = 2;
            bookLabelTwo.Text = "Book";
            // 
            // libraryLabelTwo
            // 
            libraryLabelTwo.AutoSize = true;
            libraryLabelTwo.ForeColor = SystemColors.ButtonFace;
            libraryLabelTwo.Location = new Point(217, 24);
            libraryLabelTwo.Name = "libraryLabelTwo";
            libraryLabelTwo.Size = new Size(54, 20);
            libraryLabelTwo.TabIndex = 1;
            libraryLabelTwo.Text = "Library";
            // 
            // memberLabel2
            // 
            memberLabel2.AutoSize = true;
            memberLabel2.ForeColor = SystemColors.ButtonFace;
            memberLabel2.Location = new Point(40, 24);
            memberLabel2.Name = "memberLabel2";
            memberLabel2.Size = new Size(65, 20);
            memberLabel2.TabIndex = 0;
            memberLabel2.Text = "Member";
            // 
            // memberReturnBookPanel
            // 
            memberReturnBookPanel.BackColor = SystemColors.Desktop;
            memberReturnBookPanel.Controls.Add(bt_returnBookMemberSubmit);
            memberReturnBookPanel.Controls.Add(returnLibraryMemberChoiceFLP);
            memberReturnBookPanel.Controls.Add(returnBookMemberChoiceFLP);
            memberReturnBookPanel.Dock = DockStyle.Fill;
            memberReturnBookPanel.Location = new Point(0, 0);
            memberReturnBookPanel.Margin = new Padding(3, 4, 3, 4);
            memberReturnBookPanel.Name = "memberReturnBookPanel";
            memberReturnBookPanel.Size = new Size(800, 451);
            memberReturnBookPanel.TabIndex = 4;
            memberReturnBookPanel.Tag = "memberInfoPanel";
            // 
            // bt_returnBookMemberSubmit
            // 
            bt_returnBookMemberSubmit.BackColor = SystemColors.Desktop;
            bt_returnBookMemberSubmit.ForeColor = SystemColors.ButtonFace;
            bt_returnBookMemberSubmit.Location = new Point(701, 195);
            bt_returnBookMemberSubmit.Margin = new Padding(3, 4, 3, 4);
            bt_returnBookMemberSubmit.Name = "bt_returnBookMemberSubmit";
            bt_returnBookMemberSubmit.Size = new Size(86, 63);
            bt_returnBookMemberSubmit.TabIndex = 2;
            bt_returnBookMemberSubmit.Text = "Return Book";
            bt_returnBookMemberSubmit.UseVisualStyleBackColor = false;
            bt_returnBookMemberSubmit.Click += bt_returnBookMemberSubmit_Click;
            // 
            // returnLibraryMemberChoiceFLP
            // 
            returnLibraryMemberChoiceFLP.Location = new Point(362, 20);
            returnLibraryMemberChoiceFLP.Margin = new Padding(3, 4, 3, 4);
            returnLibraryMemberChoiceFLP.Name = "returnLibraryMemberChoiceFLP";
            returnLibraryMemberChoiceFLP.Size = new Size(325, 411);
            returnLibraryMemberChoiceFLP.TabIndex = 1;
            // 
            // returnBookMemberChoiceFLP
            // 
            returnBookMemberChoiceFLP.Location = new Point(23, 21);
            returnBookMemberChoiceFLP.Margin = new Padding(3, 4, 3, 4);
            returnBookMemberChoiceFLP.Name = "returnBookMemberChoiceFLP";
            returnBookMemberChoiceFLP.Size = new Size(325, 411);
            returnBookMemberChoiceFLP.TabIndex = 0;
            // 
            // bt_goBack
            // 
            bt_goBack.BackColor = SystemColors.Desktop;
            bt_goBack.ForeColor = SystemColors.Control;
            bt_goBack.Location = new Point(0, 0);
            bt_goBack.Name = "bt_goBack";
            bt_goBack.Size = new Size(94, 29);
            bt_goBack.TabIndex = 3;
            bt_goBack.Text = "Go Back";
            bt_goBack.UseVisualStyleBackColor = false;
            bt_goBack.Click += bt_goBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(bt_goBack);
            Controls.Add(memberReturnBookPanel);
            Controls.Add(memberInfoPanel);
            Controls.Add(viewMembersPanel);
            Controls.Add(homePanel);
            Controls.Add(registerBookPanel);
            Controls.Add(registerMemberPanel);
            Controls.Add(registerLibraryPanel);
            Controls.Add(viewLibrariesPanel);
            Controls.Add(checkoutBookPanel);
            Controls.Add(addBookToLibraryPanel);
            Controls.Add(viewLibraryCheckedOutBooksPanel);
            Controls.Add(libraryInfoPanel);
            Controls.Add(viewMemberCheckedOutBooksPanel);
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
            checkedOutBookDisplay.ResumeLayout(false);
            checkedOutBookDisplay.PerformLayout();
            viewMemberCheckedOutBooksPanel.ResumeLayout(false);
            memberCheckedOutBooksDisplay.ResumeLayout(false);
            memberCheckedOutBooksDisplay.PerformLayout();
            memberReturnBookPanel.ResumeLayout(false);
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
        private Panel checkedOutBookDisplay;
        private Label memberLabel;
        private Label titleLabel;
        private Label libraryLabel;
        private Label timeLabel;
        private Button bt_memberCheckoutBook;
        private Button bt_returnBook;
        private Button bt_viewMemberBooks;
        private Panel viewMemberCheckedOutBooksPanel;
        private Panel memberCheckedOutBooksDisplay;
        private Label memberLabel2;
        private Label bookLabelTwo;
        private Label libraryLabelTwo;
        private Label timeLabelTwo;
        private Panel memberReturnBookPanel;
        private FlowLayoutPanel returnLibraryMemberChoiceFLP;
        private FlowLayoutPanel returnBookMemberChoiceFLP;
        private Button bt_returnBookMemberSubmit;
        private Button bt_goBack;
    }
}
