//Создает случайный рендомный массив
double[] CreateRandomArray(int size) //, double max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.NextDouble();
    return array;
}

//Показывает массив
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Метод находит максимальное значение массива
double arrayMax(double[] array)
{
    double maximum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];

        }
    }
    Console.WriteLine($"maximum = {maximum}");
    return maximum;
}

//Метод находит минимальное значение массива
double arrayMin(double[] array)
{
    double minimum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    Console.WriteLine($"minimum = {minimum}");
    return minimum;
}

Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());

double[] myRandomArray = CreateRandomArray(num);

ShowArray(myRandomArray);
double result = arrayMax(myRandomArray) - arrayMin(myRandomArray);
Console.WriteLine($"разница между максимальным и минимальным = {result}");
Console.ReadKey();