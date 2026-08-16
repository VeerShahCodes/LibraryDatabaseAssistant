namespace Library.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int Fees { get; set; }
        public byte MemberType { get; set; }

        public Member (int memberID, string username, string passwordHash, int fees, byte memberType)
        {
            MemberID = memberID;
            Username = username;
            PasswordHash = passwordHash;
            Fees = fees;
            MemberType = memberType;
        }
    }
}
