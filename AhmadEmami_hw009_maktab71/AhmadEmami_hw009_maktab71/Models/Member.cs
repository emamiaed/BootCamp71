namespace AhmadEmami_hw009_maktab71.Models;

public class Member
{

    public int Id { get; set; }
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime BirthDate { get; set; }
    public String? NationalCode { get; set; }
    public int MembershipTypeId { get; set; }
    public String? PhoneNumber { get; set; }
    public int GenderId { get; set; }
}