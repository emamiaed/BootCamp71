namespace AhmadEmami_hw009_maktab71.Models;

public class MemberRepository
{
    private static List<Member> _Members = new List<Member>(); 
    public List<Member> GetAllMembers()
    {
        return _Members;
    }
    public Member GetMemberDetails(int MemberId)
    {
        return _Members.Where(a => a.Id == MemberId).FirstOrDefault();
    }

    public int AddMember( Member model)
    {
        model.Id = 1;
        var lastRecord = _Members.OrderByDescending(o=>o.Id).FirstOrDefault();
        if (lastRecord != null)
            model.Id = lastRecord.Id + 1;
        _Members.Add(model);
        var dateAndTime = DateTime.Now;
        model.RegisterDate = dateAndTime.Date;
        return model.Id;
    } 
    public void UpdateMember( Member model)
    {
        var member = GetMemberDetails(model.Id);
        member.FirstName = model.FirstName;
        member.LastName = model.LastName;
        member.NationalCode= model.NationalCode;
        member.GenderId = model.GenderId;
        member.BirthDate = model.BirthDate;
        member.PhoneNumber = model.PhoneNumber;
        member.MembershipTypeId = model.MembershipTypeId;
        member.RegisterDate = model.RegisterDate;
    } 
    public Member DeleteMember(int MemberID)
    {
        var member = GetMemberDetails(MemberID);
        _Members.Remove(member);
        return member;

    } 
}