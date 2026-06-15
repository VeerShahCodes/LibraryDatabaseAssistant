namespace Library.Models
{
    public class MemberLibraryBook
    {
        public int member_id { get; set; }
        public int library_id { get; set; }
        public int book_id { get; set; }

        public MemberLibraryBook(int member_id, int library_id, int book_id)
        {
            this.member_id = member_id;
            this.book_id = book_id;
            this.library_id = library_id;
        }
    }
}
