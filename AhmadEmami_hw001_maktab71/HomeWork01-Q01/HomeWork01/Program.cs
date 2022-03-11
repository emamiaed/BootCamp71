//First Part of Homework - Question 01!
Console.WriteLine("Please Enter 1st number: ");
var num01 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter 2nd number: ");
var num02 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter 3rd number: ");
var num03 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter 4rd number: ");
var num04 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter an oprator: ");
var opt = Console.ReadKey();
switch (opt.Key)
{
    case ConsoleKey.Add:
        Console.WriteLine($"\nSum of numbers is: {num01 + num02 + num03 + num04}");
        break;
    case ConsoleKey.Multiply:
        Console.WriteLine($"\nMultiply of numbers is: {num01 * num02 * num03 * num04}");
        break;
    case ConsoleKey.Divide:
        double div01 = num01 / num02;
        double div02 = div01 / num03;
        double div03 = div02 / num04;
        Console.WriteLine($"\nDivition of numbers is:{div03}");
        break;
    case ConsoleKey.Subtract:
        Console.WriteLine($"\nSubtraction of numbers is: {num01 - num02 - num03 - num04}");
        break;
    default:
        Console.WriteLine("\nWe don't know what should we do!!!");
        break;
}
Console.WriteLine("---------------------------------------------------");
//--------------------------------------------------------------------
//Second Part of Homework - Question 01!
int[] numbers = new int[3];
string opt01 = "";
string opt02 = "";
double result = 0;
for (int u = 0; u < numbers.Length; u++)
{
    Console.WriteLine($"Please enter number {u + 1} :");
    numbers[u] = Convert.ToInt32(Console.ReadLine());
    if (numbers[0] != 0 && numbers[1] == 0)
    {
        Console.WriteLine("Please enter operator 1 :");
        opt01 = Console.ReadLine();
    }
    if (numbers[1] != 0 && numbers[2] == 0)
    {
        Console.WriteLine("Please enter operator 2 :");
        opt02 = Console.ReadLine();
    }
}
switch (opt01)
{
    case "*":
        result = numbers[0] * numbers[1];
        Console.Write($"{numbers[0]} * {numbers[1]}");
        break;
    case "/":
        result = numbers[0] / numbers[1];
        Console.Write($"{numbers[0]} / {numbers[1]}");
        break;
    case "+":
        result = numbers[0] + numbers[1];
        Console.Write($"{numbers[0]} + {numbers[1]}");
        break;
    case "-":
        result = numbers[0] - numbers[1];
        Console.Write($"{numbers[0]} - {numbers[1]}");
        break;
}
switch (opt02)
{
    case "*":
        Console.WriteLine($" * {numbers[2]} = {result * numbers[2]}");
        break;
    case "/":
        Console.WriteLine($" / {numbers[2]} = {result / numbers[2]}");
        break;
    case "+":
        Console.WriteLine($" + {numbers[2]} = {result + numbers[2]}");
        break;
    case "-":
        Console.WriteLine($" - {numbers[2]} = {result - numbers[2]}");
        break;
}
//--------------------------------------------------------------------
//Third Part of Homework - Question 01!
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Please Enter 1st number: ");
var numberPower01 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter 2nd number: ");
var numberPower02 = Convert.ToDouble(Console.ReadLine());
double powerResult = 0;
    
powerResult = Math.Pow(numberPower01, numberPower02);
Console.WriteLine($"{numberPower01} to power of {numberPower02} is: {powerResult}");

Console.WriteLine("Please Enter a number: ");
var rootNumber = Convert.ToDouble(Console.ReadLine());
double rootResult = 0;
rootResult = Math.Sqrt(rootNumber);
Console.WriteLine($"Root number of {rootNumber} = {rootResult}");
//--------------------------------------------------------------------
//Fourth Part of Homework - Question 01!
Console.WriteLine("---------------------------------------------------");
static decimal Power(decimal number, decimal raiseToPower)
{
    decimal result;
    result = number;
    for (int i = 1; i < raiseToPower; i++)
    {
        result *= number;
    }

    return result;
}
Console.WriteLine("Please enter a number: ");
var temp01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a number for power: ");
var temp02 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(temp01, temp02));
Console.WriteLine("---------------------------------------");
Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
double root = 1;
int i = 0;
while (true)
{
    i = i + 1;
    root = (number / root + root) / 2;
    if (i == number + 1) { break; }
}

Console.WriteLine("Square root:{0}", root);
Console.WriteLine("-----------------or-----------------");
Console.Write("Enter a number2:");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number2 > 0)
{
    double root2 = number2 / 3;
    int i2;
    for (i2 = 0; i2 < 32; i2++)
        root2 = (root2 + number2 / root2) / 2;
    Console.WriteLine("Square root:{0}", root2);
}
else
{
    Console.WriteLine(Double.NaN);
}