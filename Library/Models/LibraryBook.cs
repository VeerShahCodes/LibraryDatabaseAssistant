namespace Library.Models
{
    public class LibraryBook
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public int BookId { get; set; }

        public int Quantity { get; set; }

        public LibraryBook(int id, int libraryId, int bookId, int quantity)
        {
            Id = id;
            LibraryId = libraryId;
            BookId = bookId;
            Quantity = quantity;
        }
    }
}
