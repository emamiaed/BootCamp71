
Console.WriteLine("Please Enter how many number do you want to calculate");
int length = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[length];
for (int pp = 0; pp < numbers.Length; pp++)
{
	numbers[pp] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Please Enter a oprator");
var opt = Console.ReadKey();
switch (opt.Key)
{
	case ConsoleKey.Add:
		int sum = 0;
		for (int pp = 0; pp < numbers.Length; pp++)
		{
			sum += numbers[pp];
		}
		Console.WriteLine("\n" + sum);
		break;
	case ConsoleKey.Multiply:
		int multy = 1;
		for (int pp = 0; pp < numbers.Length; pp++)
		{
			multy *= numbers[pp];
		}
		Console.WriteLine("\n" + multy);
		break;
	case ConsoleKey.Divide:
		double divi = 0;
		for (int pp = 0; pp < numbers.Length; pp++)
		{
			divi /= numbers[pp];
		}
		Console.WriteLine("\n" + divi);
		break;
	case ConsoleKey.Subtract:
		int subt = 0;
		for (int pp = 0; pp < numbers.Length; pp++)
		{
			subt += numbers[pp];
		}
		Console.WriteLine("\n" + subt);
		break;
	default:
		Console.WriteLine("\nWe don't know what should we do!!!");
		break;
}