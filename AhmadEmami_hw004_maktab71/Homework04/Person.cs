public class Person
{
    public Person(string firstName, string lastName,int melliCode, int height, string mobile, string fatherName, int weight, string birthday, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        MelliCode = melliCode;
        Height = height;
        Mobile = mobile;
        FatherName = fatherName;
        Weight = weight;
        Birthday = birthday;
        Address = address;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int MelliCode { get; set; }
    public int Height { get; set; }
    public string Mobile { get; set; }
    public string FatherName { get; set; }
    public int Weight { get; set; }
    public string Birthday { get; set; }
    public string Address { get; set; }


}
