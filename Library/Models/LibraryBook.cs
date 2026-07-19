namespace Library.Models
{
    public class LibraryBook
    {
        public int id { get; set; }
        public int libraryId { get; set; }
        public int bookId { get; set; }

        public int quantity { get; set; }

        public LibraryBook(int id, int libraryId, int bookId, int quantity)
        {
            this.id = id;
            this.libraryId = libraryId;
            this.bookId = bookId;
            this.quantity = quantity;
        }
    }
}
