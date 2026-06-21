using System.Net;

namespace Frontend
{
    public partial class Form1 : Form
    {
        API api;
        public Form1()
        {
            InitializeComponent();
            registerBookPanel.Visible = false;
            registerMemberPanel.Visible = false;
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
    }
}
