using Library;
using Library.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using System.Net;

namespace Frontend
{
    public partial class Form1 : Form
    {
        API api;
        SQL sql;
        int currentLibrary = -1;
        int currentBook = -1;

        int checkOutBook = -1;
        int checkOutUser = -1;
        public Form1()
        {
            InitializeComponent();
            registerBookPanel.Visible = false;
            registerMemberPanel.Visible = false;
            registerLibraryPanel.Visible = false;
            viewLibrariesPanel.Visible = false;
            libraryInfoPanel.Visible = false;
            viewMembersPanel.Visible = false;
            memberInfoPanel.Visible = false;
            addBookToLibraryPanel.Visible = false;
            checkoutBookPanel.Visible = false;
            viewLibraryCheckedOutBooksPanel.Visible = false;
            api = new API();
        }

        private void bt_addBook_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerBookPanel.Visible = true;

        }

        private async void bt_addBookSubmit_Click(object sender, EventArgs e)
        {
            string title = tb_title.Text;
            string author = tb_author.Text;
            string genre = tb_genre.Text;

            await api.AddBookToSystem(title, author, genre);

            registerBookPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void bt_addMember_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerMemberPanel.Visible = true;
        }

        private async void bt_registerMemberSubmit_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;

            await api.RegisterMember(name);

            registerMemberPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void bt_addLibrary_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerLibraryPanel.Visible = true;
        }

        private async void bt_registerLibrarySubmit_Click(object sender, EventArgs e)
        {
            bt_registerLibrarySubmit.Enabled = false;

            string location = tb_libraryLocation.Text;
            try
            {
                await api.RegisterLibrary(location);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                bt_registerLibrarySubmit.Enabled = true;

                registerLibraryPanel.Visible = false;
                homePanel.Visible = true;
            }

        }

        private async void bt_viewLibraries_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            viewLibrariesPanel.Visible = true;
            List<Library.Models.Library> libraries = await api.GetLibraries();
            for (int i = 0; i < libraries.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = libraries[i].location;
                button.Font = new Font(FontFamily.GenericSerif, 20);
                button.AutoSize = true;
                button.Tag = libraries[i].id;
                button.Click += Button_Click;
                libraryViewerFLP.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string location = clickedButton.Text;
            currentLibrary = (int)clickedButton.Tag;

            // sql.GetLibraryID(location, out object id);
            viewLibrariesPanel.Visible = false;
            libraryInfoPanel.Visible = true;
            libraryTitleLabel.Visible = true;
            libraryTitleLabel.Text = $"{location} Library";

        }

        private async void bt_viewMembers_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            viewMembersPanel.Visible = true;
            var members = await api.GetMembers();
            if (members == null || members.Count == 0)
                return;

            memberViewerFLP.Controls.Clear();

            var sorted = members.OrderBy(m => m.name, StringComparer.OrdinalIgnoreCase).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = sorted[i].name;
                button.Font = new Font(FontFamily.GenericSerif, 9);
                button.AutoSize = true;
                button.Click += MemberButton_Click;
                memberViewerFLP.Controls.Add(button);
            }
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string name = clickedButton.Text;
            memberInfoPanel.Visible = true;
            viewMembersPanel.Visible = false;
            memberNameLabel.Text = name;
        }

        private async void bt_addLibraryBook_Click(object sender, EventArgs e)
        {
            addBookToLibraryPanel.Visible = true;
            libraryInfoPanel.Visible = false;
            booksToAddToLibraryFLP.Controls.Clear();
            var books = await api.GetBooks();
            if (books == null || books.Count == 0)
                return;
            var sorted = books.OrderBy(m => m.title, StringComparer.OrdinalIgnoreCase).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = sorted[i].title;
                button.Font = new Font(FontFamily.GenericSerif, 9);
                button.AutoSize = true;
                button.Tag = sorted[i].id;
                button.Click += Book_Click;
                booksToAddToLibraryFLP.Controls.Add(button);
            }

        }

        private async void Book_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            addBookToLibraryPanel.Visible = false;
            libraryInfoPanel.Visible = true;
            currentBook = (int)ClickedButton.Tag;

            await api.AddBookToLibrary(currentBook, currentLibrary);
        }

        private async void bt_checkoutBook_Click(object sender, EventArgs e)
        {
            checkoutBookPanel.Visible = true;
            libraryInfoPanel.Visible = false;

            List<Member> members = await api.GetMembers();
            List<LibraryBook> libraryBooks = await api.GetAvailableBooksByLibrary(currentLibrary);

            for (int i = 0; i < members.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = members[i].name;
                button.Font = new Font(FontFamily.GenericSerif, 7);
                button.AutoSize = true;
                button.Tag = members[i].id;
                button.Click += MemCheckout_Click;
                memberCheckoutFLP.Controls.Add(button);
            }

            for (int i = 0; i < libraryBooks.Count; i++)
            {
                if (libraryBooks[i].quantity > 0)
                {
                    Book book = await api.GetBookById(libraryBooks[i].bookId);

                    Button button = new Button();
                    button.BackColor = SystemColors.Desktop;
                    button.ForeColor = SystemColors.ButtonFace;
                    button.Text = book.title;
                    button.Font = new Font(FontFamily.GenericSerif, 7);
                    button.AutoSize = true;
                    button.Tag = book.id;
                    button.Click += BookCheckout_Click;
                    bookCheckoutFLP.Controls.Add(button);
                }

            }
        }

        private void BookCheckout_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            checkOutBook = (int)button.Tag;
        }

        private void MemCheckout_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            checkOutUser = (int)button.Tag;
        }

        private async void bt_confirmCheckout_Click(object sender, EventArgs e)
        {
            await api.CheckoutBook(checkOutUser, checkOutBook, currentLibrary);
            checkOutBook = -1;
            checkOutUser = -1;
            checkoutBookPanel.Visible = false;
            bookCheckoutFLP.Controls.Clear();
            memberCheckoutFLP.Controls.Clear();
            libraryInfoPanel.Visible = true;
        }

        private async void bt_viewCheckedOutBooks_Click(object sender, EventArgs e)
        {
            libraryInfoPanel.Visible = false;
            viewLibraryCheckedOutBooksPanel.Visible = true;

            List<MemberLibraryBook> checkedOutBooks = await api.GetCheckedOutBooksByLibrary(currentLibrary);

            for(int i = 0; i < checkedOutBooks.Count; i++) 
            {
                MemberLibraryBook checkedOutBook = checkedOutBooks[i];

                Member member = await api.GetMemberById(checkedOutBook.member_id);
                string name = member.name;
                Label Name = new Label();
                Name.Text = name;
                Name.Location = new Point(memberLabel.Location.X, memberLabel.Location.Y + ((i+1) * 50));
                Name.ForeColor = Color.White;

                Book book = await api.GetBookById(checkedOutBook.book_id);
                string title = book.title;
                Label Title = new Label();
                Title.Text = title;
                Title.Location = new Point(titleLabel.Location.X, titleLabel.Location.Y + ((i+1) * 50));
                Title.ForeColor = Color.White;

                Library.Models.Library library = await api.GetLibraryById(checkedOutBook.library_id);
                string location = library.location;
                Label Location = new Label();
                Location.Text = location;
                Location.Location = new Point(libraryLabel.Location.X, libraryLabel.Location.Y + ((i+1) * 50));
                Location.ForeColor = Color.White;

                DateTime toc = checkedOutBook.timeOfCheckout;
                Label Toc = new Label();
                Toc.Text = toc.Date.ToString();
                Toc.Location = new Point(timeLabel.Location.X, timeLabel.Location.Y + ((i+1) * 50));
                Toc.ForeColor = Color.White;

                checkedOutBookDisplay.Controls.Add(Name);
                checkedOutBookDisplay.Controls.Add(Title);
                checkedOutBookDisplay.Controls.Add(Location);
                checkedOutBookDisplay.Controls.Add(Toc);



            }
        }
    }
}
