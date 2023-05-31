/* Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
void DoubleArray()
{
    double[,] array = new double[3, 4];
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i, j] = new Random().NextDouble() * 2;
                Console.Write(Math.Round(array[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}



/* Напишите программу, которая на вход принимает 
значение элемента в двумерном массиве, и возвращает
 позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.Write("Введите ваше число: ");
int inp = Convert.ToInt32(Console.ReadLine());
int indx = 0;
int indy = 0;
        int[,] array = new int[3, 4];
            for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1,10);
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
if(inp != array[indx, indy])
{
    for(indx = 0; indx < array.GetLength(0); indx++)
    {
        for(indy = 0; indy < array.GetLength(1); indy++)
        {

        }
    }
}
else
{
    Console.WriteLine(indx + " " + indy);
}




/* Задача 52. Задайте двумерный массив из целых 
чисел. Найдите среднее арифметическое элементов 
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* int sum = 0;

int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[j, i] = new Random().Next(1,10);
            Console.Write(array[j,i] + " ");
            sum += array[j,i];
        
        }
        Console.WriteLine();
        Console.WriteLine(sum + " ");
    }
 */