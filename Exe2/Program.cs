//Создает массив
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//Показывает массив
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Метод складывет нечетные числа в массиве
int sumOddNumber(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            temp = array[i] + temp;
            Console.WriteLine($"Числа на нечетных местах array[{i}] = {array[i]}");
        }
    }
    return temp;
}

Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);

ShowArray(myRandomArray);
Console.WriteLine($"сумма чисел на нечетных местах в массиве {sumOddNumber(myRandomArray)}");
Console.ReadKey();