namespace Library.Models
{
    public class Series
    {
        public int SeriesID { get; set; }
        public string Name { get; set; }

        public Series(int seriesID, string name)
        {
            SeriesID = seriesID;
            Name = name;
        }
    }
}
