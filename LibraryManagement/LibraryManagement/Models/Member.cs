namespace LibraryManagement.Models
{
    internal class Member
    {
        public Member(int memberID, string name, string contactInfo, DateTime membershipDate)
        {
            MemberID = memberID;
            Name = name;
            ContactInfo = contactInfo;
            MembershipDate = membershipDate;
        }

        public int MemberID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
