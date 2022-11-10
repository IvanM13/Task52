/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string? num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено не число");
        else
        {
            if (number <= 0)
                Console.WriteLine("Задайте число больше 0");
            else
                return number;
        }
    }
}

int[,] ArrayRandom(int line, int column)
{
    int[,] arr = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("Двумерный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }

}

void ArithmeticMean(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < arr.GetLength(0); i++) mean = mean + arr[i, j];
        Console.WriteLine($"Среднее арифретическое {j + 1} столбца равно: {mean / arr.GetLength(0):0.000}");
    }

}

int line = GetNumber("Задайте число строк m: ");
int column = GetNumber("Задайте число столбцов n : ");
int[,] rnd = ArrayRandom(line, column);
PrintArray(rnd);
ArithmeticMean(rnd);
