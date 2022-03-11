Console.WriteLine("Please enter a string of characters:");
var str01 = Console.ReadLine();
Console.WriteLine("Please enter another string of characters:");
var str02 = Console.ReadLine();
int len1 = str01.Length;
int len2 = str02.Length;
int finalLen = 0;
if (len1 >= len2)
{
    finalLen = len1;
}
else
{
    finalLen = len2;
}
char[] ch01 = new char[finalLen];
char[] ch02 = new char[finalLen];
for (int i = 0; i < str01.Length; i++)
{
    ch01[i] = str01[i];
}
for (int i = 0; i < str02.Length; i++)
{
    ch02[i] = str02[i];
}
char[] temp = new char[ch02.Length];

for (int i = 0; i < finalLen; i++)
{
    bool bl = true;
    for (int j = 0; j < finalLen; j++)
    {
        if (ch01[i] == ch02[j])
        {
            temp[i] = ch02[j];
        }
    }
    for (int j = i - 1; j >= 1; j--)
    {
        if (ch01[i] == ch01[j])
        {
            bl = false;
        }
    }

    if (bl == true)
    {
        Console.Write(temp[i]);
    }

}