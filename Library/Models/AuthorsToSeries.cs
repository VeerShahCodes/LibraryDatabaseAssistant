namespace Library.Models
{
    public class AuthorsToSeries
    {
        int ATSID { get; set; }
        int AuthorID { get; set; }
        int SeriesID { get; set; }

        public AuthorsToSeries(int ATSID, int AuthorID,  int SeriesID)
        {
            this.ATSID = ATSID;
            this.AuthorID = AuthorID;
            this.SeriesID = SeriesID;
        }
    }
}
