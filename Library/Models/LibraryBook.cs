namespace Library.Models
{
    public class LibraryBook
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public int BookId { get; set; }

        public LibraryBook(int id, int libraryId, int bookId)
        {
            Id = id;
            LibraryId = libraryId;
            BookId = bookId;
        }
    }
}
