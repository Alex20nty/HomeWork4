// Написать программу замену элементов массива на противоположные

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random(). Next(-10, 10);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    while(i < count)
    {
        Console.Write($" {array[i]} ");
        i++;
    }
}
int[] newArray = new int[10];


int Opposite(int[] massive)
{
    int length = massive.Length;
    int opp = 0;
    for(int i = 0; i < length; i++)
    {
        opp = -1 * massive[i];
        Console.Write($" {opp} ");
    } 
    return opp;
    
}
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
Opposite(newArray);