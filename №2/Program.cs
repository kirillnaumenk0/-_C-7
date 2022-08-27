/* Задача 50. Напишите программу, которая на вход принимает ПОЗИЦИИ ЭЛЕМЕНТА в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет*/
//Решение которое принимает на вход число как показано в примере:


/* Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


void Search(int[,] matr)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                k++;
            }
        }
    }
    if (k == 0)
    {
        Console.WriteLine(num + " Такого числа нет в массиве");
    }
    else
    {
        Console.WriteLine(num + " Данное число обнаружено " + k + " раза");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Search(matrix); */


//Решение которое принимает на вход ПОЗИЦИИ ЭЛЕМЕНТА как написано в условие:

Console.WriteLine("Введите позицию №1(строка)");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию №2(столбец)");
int second = Convert.ToInt32(Console.ReadLine());


void Search(int[,] matr)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == first && j == second)
            {
                Console.WriteLine($"{matr[i, j]} " + " Данное число по позиции " + first + "," + second + " " + "обнаружено в массиве");
                k++;
                break;
            }
        }
    }
    if (k == 0)
    {
        Console.WriteLine(first + "," + second + " " + " Такого числа нет в массиве");
    }
}

void PrintArray(int[,] matr)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 50);
        }
    }
}

int[,] matrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Search(matrix);
