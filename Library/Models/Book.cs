namespace Library.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string author { get; set; }

        public Book(int id, string title, string genre, string author)
        {
            this.id = id;
            this.title = title;
            this.genre = genre;
            this.author = author;
        }
    }
}
