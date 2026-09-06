namespace Library.Models
{
    public class BooksToGenres
    {
        public int BTGID { get; set; }
        public int BookID { get; set; }
        public int GenreID { get; set; }

        public BooksToGenres(int btgID, int bId, int gId) 
        {
            BTGID = btgID; 
            BookID = bId;
            GenreID = gId;
        }
    }
}
