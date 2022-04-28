// Определить, присутствует ли в заданном массиве, некоторое число




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

int[] newArray = new int[10];

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = -1;
    while(i < count)
    {
        if(collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
int pos = IndexOf(newArray, 8);
Console.WriteLine(pos);