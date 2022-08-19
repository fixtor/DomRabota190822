int[] CreateRandomArray(int lenght, int start, int end)
{
    int[] RandomArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] myRandomArray = CreateRandomArray(num, min, max);