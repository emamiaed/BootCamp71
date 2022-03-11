int num = 8;
num *= Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[num];
double total = 0;
for (int j = 0; j < num; j++)
{
    Console.Write($"Please enter your number {j + 1} : ");
    numbers[j] = Convert.ToDouble(Console.ReadLine());
}
Array.Reverse(numbers);
int i = 0;
while (i < numbers.Length)
{

    total = ((numbers[i] * numbers[i + 1]) + (numbers[i + 2] / numbers[i + 3]) + (numbers[i + 4] - numbers[i + 5]) + (numbers[i + 6] + numbers[i + 7]));
    i = numbers.Length;
}
Console.WriteLine(total);
if (total > 0)
{
    Console.WriteLine("Valid");
}
else if (total == 0)
{
    Console.WriteLine("the result is zero");
}
else
{
    Console.WriteLine("Invalid");
}
