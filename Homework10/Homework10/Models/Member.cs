namespace Homework10.Models
{
    public class Member
    {
        public int Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public DateTime RegisterDate { get; set; }=DateTime.Now;
        public DateTime BirthDay { get; set; }
        public String? NationalCode { get; set; }
        public int MembershipType { get; set; }
        public String? PhoneNumber { get; set; }
        public int Gender { get; set; }
    }
}
