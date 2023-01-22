// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int[] RandArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int[] myArray = RandArray(6, 1, 100);
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
    if (i % 2 != 0) sum += myArray[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на четных позициях в массиве {sum}");