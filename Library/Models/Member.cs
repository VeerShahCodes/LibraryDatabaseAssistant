namespace Library.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Fees { get; set; }
        public byte MemberType { get; set; }

        public Member (int memberID, string username, string password, double fees, byte memberType)
        {
            MemberID = memberID;
            Username = username;
            Password = password;
            Fees = fees;
            MemberType = memberType;
        }
    }
}
