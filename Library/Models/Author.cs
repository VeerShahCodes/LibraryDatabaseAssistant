namespace Library.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

        public Author(int authorID, string name)
        {
            AuthorID = authorID;
            Name = name;
        }
    }
}
