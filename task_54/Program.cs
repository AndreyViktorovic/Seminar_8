// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);
for (int i = 0; i < numbers.GetLength(0); ++i)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; ++j)
        {
        for (int a = 0; a < numbers.GetLength(1) - 1; ++a)
            {
                if (numbers[i, a] < numbers[i, a + 1]) 
                {
                    int temp = 0;
                    temp = numbers[i, a];
                    numbers[i, a] = numbers[i, a + 1];
                    numbers[i, a + 1] = temp;
                }
            }
        }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
    Console.WriteLine("");
    }
}