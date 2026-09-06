namespace Library.Models
{
    public class BooksToSeries
    {
        int BTSID { get; set; }
        int BookID { get; set; }
        int SeriesID { get; set; }

        public BooksToSeries(int btsID, int bookID, int seriesID)
        {
            BTSID = btsID;
            BookID = bookID;
            SeriesID = seriesID;
        }
    }
}
