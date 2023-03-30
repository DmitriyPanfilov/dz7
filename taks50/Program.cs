// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,50); // 1 - 9
            Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void NumberSearch(int[,] matrix, int number)
{
    int resalt = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number)
                resalt += 1;
            
        }
    }
     if(resalt == 0)
            Console.WriteLine($"Числа {number} нет");
        else
        {
            Console.WriteLine($"Число {number} есть");
        }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
InputMatrix(matrix);
NumberSearch(matrix, number);
