Console.Write("Введите номер задачи:");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
case 1:
{
    DoubleArray();
    break;
}
case 2:
{
    FindNum();
    break;
}
case 3:
{
    AverNumb();
    break;
}
default:
{
    Console.WriteLine("некорректное значение");
    break;
}
}

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
void FindNum()
{
Console.Write("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool pos = false;
int[,] number = new int[3, 4];
Randarr(number);
PrintArr(number);
for (int i = 0; i < number.GetLength(0); i++)
{
        if (!pos)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            if (num == number[i, j])
            {
                pos = true;
                Console.WriteLine($"Столбец - {i + 1} строка - {j + 1}");
                break;
            }
            
        }
        
    }
}
    if (!pos)
    {
        Console.WriteLine($"Числа {num} в массиве нет");
    }

void Randarr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}  


    void PrintArr(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }

}
/* Задача 52. Задайте двумерный массив из целых 
чисел. Найдите среднее арифметическое элементов 
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void AverNumb()
{
    Console.Write("Введите число строк: ");
    int indx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int indy = Convert.ToInt32(Console.ReadLine());

    int[,] numb = new int[indx, indy];
    RandNum(numb);
    PrintArr(numb);
    Console.Write("Среднее арифметическое столбца: ");
    for (int j = 0; j < numb.GetLength(1); j++)
    {
        double aver = 0;
        for (int i = 0; i < numb.GetLength(0); i++)
        {
            aver = (aver + numb[i, j]);
        }
        aver = aver / indx;

        Console.Write(Math.Round(aver, 1) + "; ");
    }
    Console.WriteLine();

    void RandNum(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }   
    
    void PrintArr(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
}