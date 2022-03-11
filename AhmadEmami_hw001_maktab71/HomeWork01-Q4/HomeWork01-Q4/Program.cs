using System.Text.RegularExpressions;
ConsoleKeyInfo cki;
do
{
    string pat = "[a-z]+";
    Console.Write("Please enter numbers : ");
    string input = Console.ReadLine();
    string[] result = Regex.Split(input, pat);
    int ctr;
    for (ctr = 0; ctr < result.Length; ctr++)
    {
        Console.Write("{0}\t", result[ctr]);
    }
    int[] numbers = new int[ctr];
    int i = 0;
    while (i < ctr)
    {
        int.TryParse(result[i], out numbers[i]);
        i++;
    }
    Console.WriteLine("\n");
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }
    Console.Write("Press the Escape (Esc) key to quit : ");
    cki = Console.ReadKey();
    Console.WriteLine();
} while (cki.Modifiers != ConsoleModifiers.Control || cki.Key != ConsoleKey.Y);