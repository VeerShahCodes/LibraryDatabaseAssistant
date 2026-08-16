namespace Library.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }

        public Genre(int id, string name)
        {
            GenreID = id;
            Name = name;
        }
    }
}
