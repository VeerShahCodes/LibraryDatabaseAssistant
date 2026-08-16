namespace Library.Models
{
    public class Library
    {
        int LibraryID { get; set; }
        string Name { get; set; }

        public Library (int id, string name)
        {
            LibraryID = id;
            Name = name;
        }
    }
}
