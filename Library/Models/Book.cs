namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Book(int id, string title, string desc)
        {
            BookId = id;
            Title = title;
            Description = desc;
        }
    }
}
