// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(0, 50);
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
Console.WriteLine();

int Production(int[] newArray)
{
    int length = newArray.Length;
    int index = 0;
    int last = 9;
    int prod = 0;
    while(index < last)
    {
        prod = newArray[index]*newArray[last];
        index++;
        last--;
        Console.WriteLine("Произведение пар чисел = " +prod);
    }
    return prod;
}
int result = Production(newArray);