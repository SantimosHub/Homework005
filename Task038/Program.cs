// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] RandArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int Diff()
{
    int[] myArray = RandArray(6, 1, 50);
    int max = myArray[0];
    int min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
        if (myArray[i] > max) max = myArray[i];
        else if (myArray[i] < min) min = myArray[i];
    }
    Console.WriteLine();
    return max - min;
}

Console.WriteLine($"Разница между максимальным и минимальным числами в массиве {Diff()}");