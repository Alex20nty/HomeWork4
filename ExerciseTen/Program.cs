// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] array = new int[] {2, 8, 3, 6, 5, 1, 7, 6, 4, 9};
 
int max = int.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
} 
Console.WriteLine("Максимальный элемент =" +max);

int min = int.MaxValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
} 
Console.WriteLine("Минимальный элемент =" +min);

int result = max - min;
Console.WriteLine("Их разница =" +result);