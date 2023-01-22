// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int[] myArray = RandArray(10, 100, 1000);
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
    if (myArray[i] % 2 == 0) count += 1;
}
Console.WriteLine();
Console.WriteLine($"Число четных чисел в массиве {count}");