namespace Library.Models
{
    public class BooksToAuthors
    {
        int BTAID { get; set; }
        int BookID { get; set; }
        int AuthorID { get; set; }

        public BooksToAuthors(int BTAID, int BookID, int AuthorID)
        {
            this.BTAID = BTAID; ;
            this.BookID = BookID;
            this.AuthorID = AuthorID;
        }
    }
}
