namespace Library.Models
{
    public class MemberLibraryBook
    {
        public int id { get; set;  }
        public int member_id { get; set; }
        public int book_id { get; set; }
        public int library_id { get; set; }

        public DateTime timeOfCheckout { get; set; }

        public MemberLibraryBook(int id, int member_id, int book_id, int library_id, DateTime timeOfCheckout)
        {
            this.id = id;
            this.member_id = member_id;
            this.book_id = book_id;
            this.library_id = library_id;
            this.timeOfCheckout = timeOfCheckout;
        }
    }
}
