// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($" {array[position]} ");
        position++;
    }
}

int[] newArray = new int[10];
FillArray(newArray);
PrintArray(newArray);

int SumOdd(int[] newArray)
{
    int length = newArray.Length;
    int sum = 0;
    for(int i = 0; i < length; i++)
    {
        if(i % 2 == 0)
        {
            sum = sum + newArray[i];
        }
    }
    return sum;
}

int result = SumOdd(newArray);
Console.WriteLine();
Console.WriteLine("Сумма нечетных чисел массива = " +result);