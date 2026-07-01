namespace Library.Models
{
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }

        public Member(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
