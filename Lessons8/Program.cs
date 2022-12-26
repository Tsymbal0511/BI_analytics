//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.
/*

int m;
int n;

while (true)
{
    Console.WriteLine("Введите число m");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n");
    n = int.Parse(Console.ReadLine());
    if (m == n)
    {
        break;
    }
    Console.WriteLine("Введены не верные данные");
}
int[,] arrayresult = CreateArrayWhithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
int[,] reversearray = ReverseArray(arrayresult);
Print2DArray(reversearray);

int[,] CreateArrayWhithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 30);
        }
    }
    return array;
}

int[,] ReverseArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array(j, i);
        }
    }
    return result;
}



void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

*/
//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//1, 2, 3 4, 6, 1 2, 1, 6
//1 встречается 3 раза, 2 встречается 2 раз, 3 встречается 1 раз, 4 встречается 1 раз, 6 встречается 2 раза


Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число number");
int number = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWhithRandomNumber(m, n);
//Print2DArray(arrayresult);

Console.WriteLine($"{number} повторяется сколько раз:" + FindElementinArray(arrayresult));
int[,] CreateArrayWhithRandomNumber(int m, int n)
{
   Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 5);
        }
    }
    return array; 
}

int FindElementinArray(int[,] array)
{
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            index++;
        }
    }
    return index;
}



//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив: 14 72
//59 23
//84 24
//52 67
//Наименьший элемент - 1, на выходе получим следующий массив:
//94 2
//22 6
//34 7


