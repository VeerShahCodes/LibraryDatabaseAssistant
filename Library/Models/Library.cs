namespace Library.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Location { get; set; }

        public Library(int id, string location)
        {
            Id = id;
            Location = location;
        }
    }
}
