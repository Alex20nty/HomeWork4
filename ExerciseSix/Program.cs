// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел


void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(100, 1000);
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


int l = newArray.Length;
int even = 0;
int odd = 0;
int i = 0;

while(i < l)
{
    if(newArray[i] % 2 == 0) even++;
    else odd++;
    i++;
}


Console.WriteLine();
Console.WriteLine($" четных - {even} нечетных - {odd} ");

