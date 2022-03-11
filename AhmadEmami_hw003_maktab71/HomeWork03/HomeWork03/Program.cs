//--------------------------------------------------Q01
//--------------------------------------------------Q02
//--------------------------------------------------Q03


//--------------------------------------------------Q04
Console.WriteLine("-----------Q04-------------------");
Console.WriteLine(ContactTypeEnum.SMS);
Console.WriteLine(ContactTypeEnum.Mail);
//---------------------------------------------------Q05
Console.WriteLine("-----------Q05-------------------");
String[] Str = ContactTypeEnum.GetNames(typeof(ContactTypeEnum));
foreach (string s in Str)
    Console.WriteLine(s);
//--------------------------------------------------Q06
Console.WriteLine("-----------Q06-------------------");
var enumCast = Enum.GetValues(typeof(ContactTypeEnum));
Console.WriteLine("Select Your Contact No. From Numlock:");
Console.WriteLine("1 - SMS");
Console.WriteLine("2 - Mail");
var contactNum = Console.ReadKey();
switch (contactNum.Key)
{
    case ConsoleKey.NumPad1:
        Console.WriteLine("\nYou Select a SMS for Contact");
        break;
    case ConsoleKey.NumPad2:
        Console.WriteLine("\nYou Select a Mail for Contact");
        break;

}
//---------------------------------------------------Q07
Console.WriteLine("-----------Q07-------------------");
Array stm = ContactTypeEnum.GetValues(typeof(ContactTypeEnum));
foreach (int num in stm)
    Console.WriteLine(num);
//--------------------------------------------------Q08


//---------------------------------------------------Q09
Console.WriteLine("-----------Q09-------------------");
Console.WriteLine("Select Your Contact :");
Console.WriteLine("S - SMS");
Console.WriteLine("M - Mail");

var myContact = Console.ReadKey();
ContactTypeEnum contact = ContactTypeEnum.SMS;
switch (myContact.Key)
{
    case ConsoleKey.S:
        contact = ContactTypeEnum.SMS;
        Console.WriteLine("\nYou Select a SMS for Contact");
        break;
    case ConsoleKey.M:
        contact = ContactTypeEnum.Mail;
        Console.WriteLine("\nYou Select a Mail for Contact");
        break;

}