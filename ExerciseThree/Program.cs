// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива


void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(0, 10);
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

void SumArray(int[] ourArray)
{
    int number = ourArray.Length;
    int sum = 0;
    for(int i = 0; i < number; i++)
    {
        if(ourArray[i] > 0)
        {
            sum = sum + ourArray[i];
            Console.WriteLine(sum);
        }
            if(ourArray[i] < 0)
            {
                Console.WriteLine("-1");
            }
    }
}
int[] newArray = new int[12];
FillArray(newArray);
PrintArray(newArray);
SumArray(newArray);


