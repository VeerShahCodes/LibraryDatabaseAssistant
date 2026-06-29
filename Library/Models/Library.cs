namespace Library.Models
{
    public class Library
    {
        public int id { get; set; }
        public string location { get; set; }

        public Library(int id, string location)
        {
            this.id = id;
            this.location = location;
        }
    }
}
