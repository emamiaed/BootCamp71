bool flag = true;
string name, family, newName, newFamily;
CRUDRepository cr = new();
while (flag == true)
{
    Console.Clear();
    Console.WriteLine("Would You Like To Continue? y / n");
    var ans = Console.ReadKey().Key;
    if (ans == ConsoleKey.Y)
    {
        Console.WriteLine();
        Console.WriteLine("Choose Operation:");
        Console.WriteLine("A-AddPerson R-ReedAll F-Find D-Delete U-Update C-Compare Two Person");
        var operaton = Console.ReadKey().Key;
        Console.WriteLine();
        if (operaton == ConsoleKey.A)
        {
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Family:");
            family = Console.ReadLine();

            Person p = new Person();
            p.Name = name;
            p.Family = family;
            cr.InsertPerson(p);
            //DataSource._person.Add(p);
        }
        else if (operaton == ConsoleKey.R)
        {
            var items = cr.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} {item.Family}");
            }
        }
        else if (operaton == ConsoleKey.F)
        {

            Console.WriteLine("Enter Your Name To Find:");
            name = Console.ReadLine();
            cr.FindPerson(name);
        }
        else if (operaton == ConsoleKey.D)
        {
            Console.WriteLine("Enter Your Name To Delete:");
            name = Console.ReadLine();
            cr.DeletePerson(name);
        }
        else if (operaton == ConsoleKey.U)
        {
            Console.WriteLine("Enter Your Name To Update:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your New Name ");
            newName = Console.ReadLine();
            Console.WriteLine("Enter Your New Family ");
            newFamily = Console.ReadLine();
            cr.UpdatePerson(name, newName, newFamily);
        }

        else if (operaton == ConsoleKey.C)
        {

            if (DataStorage._person.Count > 1)
            {
                if (DataStorage._person[0].Equals(DataStorage._person[1]))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Not OK");
                }
            }
            else
            {
                Console.WriteLine("Enter atleast two person");
            }
        }
    }
    else if (ans == ConsoleKey.N)
    {
        Console.WriteLine("\t");
        flag = false;
    }
    else
    {
        Console.WriteLine("Enter Valid Answer!!!");
        flag = false;
    }
}