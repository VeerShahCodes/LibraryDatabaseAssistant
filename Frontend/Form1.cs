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

        private void bt_viewMembers_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            viewMembersPanel.Visible = true;
            var members = api.GetMembers();
            if (members == null || members.Result.Count == 0)
                return;

            memberViewerFLP.Controls.Clear();

            var sorted = members.Result.OrderBy(m => m.name, StringComparer.OrdinalIgnoreCase).ToList();

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

        private void bt_addLibraryBook_Click(object sender, EventArgs e)
        {
            addBookToLibraryPanel.Visible = true;
            libraryInfoPanel.Visible = false;
            booksToAddToLibraryFLP.Controls.Clear();
            var books = api.GetBooks();
            if (books == null || books.Result.Count == 0)
                return;
            var sorted = books.Result.OrderBy(m => m.title, StringComparer.OrdinalIgnoreCase).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = sorted[i].title;
                button.Font = new Font(FontFamily.GenericSerif, 9);
                button.AutoSize = true;
                button.Tag = sorted[i].id;
                button.Click += Button_Click;
                booksToAddToLibraryFLP.Controls.Add(button);
            }

        }

        private async Task Book_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            addBookToLibraryPanel.Visible = false;
            libraryInfoPanel.Visible = true;
            currentBook = (int)ClickedButton.Tag;

            await api.AddBookToLibrary(currentBook, currentLibrary);
        }

        private void bt_checkoutBook_Click(object sender, EventArgs e)
        {

        }
    }
}
