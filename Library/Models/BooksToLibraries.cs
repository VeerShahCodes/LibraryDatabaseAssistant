namespace Library.Models
{
    public class BooksToLibraries
    {
        public int BooksToLibrariesID { get; set; }
        public int BookID { get; set; }
        public int LibraryID { get; set; }
        public int Count { get; set; }
        public BooksToLibraries(int btlID, int bID, int lID, int count)
        {
            BooksToLibrariesID = btlID;
            BookID = bID;
            LibraryID = lID;
            Count = count;
        }
    }
}
