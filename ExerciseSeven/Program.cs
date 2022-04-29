// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] newArray = new int[123];

int NumberOf(int[] newArray)
{
    int num = 0;
    for(int i = 10; i < 99; i++)
    {
        num = num + 1;
    }
    return num;
}

int result = NumberOf(newArray);
System.Console.WriteLine(result);
