public class CRUDRepository : IPersonRepository
{
    public void DeletePerson(string name)
    {
        var p = DataStorage._person.FirstOrDefault(x => x.Name == name);
        if (p != null)
        {
            DataStorage._person.RemoveAll(x => x.Name == name);
            Console.WriteLine($"{p.Name} {p.Family} Removed.");
        }
        else
        {
            Console.WriteLine("There is No Person Like this!");
        }
    }

    public void FindPerson(string name)
    {
        var p = DataStorage._person.FirstOrDefault(n => n.Name == name);
        if (p != null)
        {
            Console.WriteLine($"{p.Name} {p.Family} Founded");
        }
        else
        {
            Console.WriteLine("This Person Not Found!");
        }
    }

    public IList<Person> GetAll()
    {
        return DataStorage._person.ToList();
    }

    public void InsertPerson(Person person)
    {
        DataStorage._person.Add(person);
    }

    public void UpdatePerson(string name, string newName, string newFamily)
    {
        var p = DataStorage._person.FirstOrDefault(x => x.Name == name);
        if (p != null)
        {
            Console.WriteLine($"{p.Name} {p.Family} Modified To :{newName} {newFamily} ");
            p.Name = newName;
            p.Family = newFamily;

        }
        else
        {
            Console.WriteLine("This Person Not Found!");
        }
    }
}