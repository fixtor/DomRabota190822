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


void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Метод показывает количество четных чисел в массиве
int evenNumbers(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] = {array[i]} ");
        if (array[i] % 2 == 0)
        {
            temp++;
            Console.WriteLine($"temp {temp} i:{i}, array[{i}] = {array[i]}");
            Console.ReadKey();
        }
    }
    Console.WriteLine();
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.WriteLine($"array[{i}] = {array[0]}");
    //     

    // }
    Console.WriteLine($"arraylenght {array.Length}");
    return temp;
}



//Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
//int[] myArray = new int[] CreateRandomArray(num,min,max);

Console.WriteLine($"temp = {evenNumbers(myRandomArray)}");
Console.ReadKey();

// Проверка на отрицательные числа или min больше max
//if (min < 0 || min > max)
//    Console.WriteLine($"Вы ввели отрицательное число или число меньше максимального {min}, {max}");




