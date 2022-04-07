public interface IPersonRepository
{
    void InsertPerson(Person person);
    IList<Person> GetAll();
    public void FindPerson(string name);
    public void DeletePerson(string name);
    void UpdatePerson(string name, string newName, string newFamily);
}