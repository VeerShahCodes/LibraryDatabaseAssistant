using Library;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;
using System.Linq;

namespace Frontend
{
    public partial class Form1 : Form
    {
        API api;
        SQL sql;
        public Form1()
        {
            InitializeComponent();
            registerBookPanel.Visible = false;
            registerMemberPanel.Visible = false;
            registerLibraryPanel.Visible = false;
            viewLibrariesPanel.Visible = false;
            libraryInfoPanel.Visible = false;
            viewMembersPanel.Visible = false;
            api = new API();
        }

        private void bt_addBook_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerBookPanel.Visible = true;

        }

        private void bt_addBookSubmit_Click(object sender, EventArgs e)
        {
            string title = tb_title.Text;
            string author = tb_author.Text;
            string genre = tb_genre.Text;

            api.AddBookToSystem(title, author, genre);

            registerBookPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void bt_addMember_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerMemberPanel.Visible = true;
        }

        private void bt_registerMemberSubmit_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;

            api.RegisterMember(name);

            registerMemberPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void bt_addLibrary_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            registerLibraryPanel.Visible = true;
        }

        private void bt_registerLibrarySubmit_Click(object sender, EventArgs e)
        {
            string location = tb_libraryLocation.Text;

            api.RegisterLibrary(location);

            registerLibraryPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void bt_viewLibraries_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            viewLibrariesPanel.Visible = true;
            var libraries = api.GetLibraries();
            for (int i = 0; i < libraries.Count; i++)
            {
                Button button = new Button();
                button.BackColor = SystemColors.Desktop;
                button.ForeColor = SystemColors.ButtonFace;
                button.Text = libraries[i].location;
                button.Font = new Font(FontFamily.GenericSerif, 20);
                button.AutoSize = true;
                button.Click += Button_Click;
                libraryViewerFLP.Controls.Add(button);
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string location = clickedButton.Text;

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

        private void MemberButton_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string name = clickedButton.Text;
        }
    }
}
