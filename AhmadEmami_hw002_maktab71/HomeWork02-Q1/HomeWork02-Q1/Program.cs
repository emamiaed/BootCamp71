Console.WriteLine("please enter interger array:");
var input = Console.ReadLine();
string[] inputArray = input.Split(',');
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = inputArray[i].Trim();
}
int[] inputNumber = new int[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    inputNumber[i] = Convert.ToInt32(inputArray[i]);
}
Console.WriteLine("please select a method:");
Console.WriteLine("1- Find Minimum");
Console.WriteLine("2- Print Reverse Of Array");
Console.WriteLine("3- Find Duplicate in Array");
Console.WriteLine("4- Compair Two Array");
int methodType = Convert.ToInt32(Console.ReadLine());
switch (methodType)
{
    case 1:
        Console.WriteLine(Min(inputNumber));
        break;
    case 2:
        PrintArray(ReverseOfArray(inputNumber));
        break;
    case 3:
        FindDuplicates(inputNumber);
        break;
    case 4:
        CompairTowArray();
        break;
    default:
        break;
}
//----------------------------------------------------------------------
int Min(int[] arr)
{
    int min = arr[0];
    foreach (var item in arr)
    {
        if (item < min)
            min = item;
    }
    return min;
}
//--------------------------------------------------------------------
int[] ReverseOfArray(int[] arr)
{
    int n = arr.Length;
    int[] temp = new int[n];
    for (int i = 0; i < n; i++)
    {
        temp[n - 1 - i] = arr[i];
    }

    for (int i = 0; i < n; i++)
    {
        arr[i] = temp[i];
    }
    return arr; 
}
//--------------------------------------------------------------------
void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} - ");
    }
}
//----------------------------------------------------------------------
void FindDuplicates(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0, bl = 1;
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
            }
        }
        for (int j = i - 1; j >= 0; j--)
        {
            if (arr[i] == arr[j])
            {
                bl = 0;
            }
        }

        if (bl == 1 && count >1)
        {
            Console.WriteLine("Item: "+arr[i] + "\t" + "Repeated: " + count);

        }
    }
}
//------------------------------------------------------------
void CompairTowArray()
{
    Console.WriteLine("please enter another interger array:");
    var input = Console.ReadLine();
    string[] inputArray2 = input.Split(',');
    for (int i = 0; i < inputArray2.Length; i++)
    {
        inputArray2[i] = inputArray2[i].Trim();
    }
    int[] inputNumber2 = new int[inputArray2.Length];

    for (int i = 0; i < inputArray2.Length; i++)
    {
        inputNumber2[i] = Convert.ToInt32(inputArray2[i]);
    }
    int[] temp = new int[inputNumber.Length];
    for (int i = 0; i < inputNumber.Length; i++)
    {
        int bl = 1;
        for (int j = 0; j < inputNumber2.Length; j++)
        {
            if (inputNumber[i] == inputNumber2[j])
            {
                temp[i] = inputNumber2[j];
            }
        }
        for (int j = i - 1; j >= 1; j--)
        {
            if (inputNumber[i] == inputNumber[j])
            {
                bl = 0;
            }
        }

        if (bl == 1)
        {
            Console.Write(Convert.ToString(temp[i])+",");
        }

    }
}
