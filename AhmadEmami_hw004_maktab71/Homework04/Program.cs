var filePath = @"..\..\..\Person.txt";
if (System.IO.File.Exists(filePath))
{
    System.IO.File.WriteAllText(filePath, string.Empty);
}
else
{
    File.CreateText(filePath);
}
void MyMenu()
{
    Console.Clear();
    Console.WriteLine("------ Wellcome--------");
    Console.WriteLine("E - Enter Data");
    Console.WriteLine("V - View Data");
    var inputKey = Console.ReadKey();
    if (inputKey.Key == ConsoleKey.E)
    {
        DataEntry();
        MyMenu();
    }
    else if (inputKey.Key == ConsoleKey.V)
    {
        List<string> lines = new List<string>(File.ReadAllLines(filePath));
 
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\n"+lines[i]);
        }

        Console.WriteLine("Press Any Key to Continue...");
        Console.ReadKey();
        MyMenu();
    }
    else
    {
        Console.WriteLine("You Press Invalid Key , Please Try Again.");
        Console.WriteLine("Press Any Key To Continue...");
        Console.ReadKey();
        MyMenu();
    }
}
MyMenu();






void DataEntry()
{
    Console.WriteLine("\nPlease Enter these data to store on File");
    Console.WriteLine("----------------------------------------");
    Console.Write("Please Enter Your First Name : ");
    var firstName = Console.ReadLine();
    File.AppendAllText(filePath,firstName);

    Console.Write("Please Enter Your Last Name : ");
    var lastName = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + lastName);

    Console.Write("Please Enter Your National Code : ");
    var melliCode = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + melliCode);

    Console.Write("Please Enter Your Father Name : ");
    var fatherName = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + fatherName);

    Console.Write("Please Enter Your Mobile Number : ");
    var mobile = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + mobile);

    Console.Write("Please Enter Your Height : ");
    var height = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + height);

    Console.Write("Please Enter Your Weight : ");
    var weight = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + weight);

    Console.Write("Please Enter Your Date of Birth : ");
    var birthday = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + birthday);

    Console.Write("Please Enter Your Address : ");
    var address = Console.ReadLine();
    File.AppendAllText(filePath, "\n" + address);
}



