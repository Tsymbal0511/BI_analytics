using System;
//Задача No18. Общее обсуждение
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
int number = ReadNumber("Введите номер четверти: ");

switch (number)
{
    case 1:
        WriteNumber("Диапазон: x>0, y>0");
        break;
    case 2:
        WriteNumber("Диапазон: x>0, y<0");
        break;
    case 3:
        WriteNumber("Диапазон: x<0, y<0");
        break;
    case 4:
        WriteNumber("Диапазон: x<0, y>0");
        break;
}

int ReadNumber(string text)
{
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) { }
    else
    {
        Console.WriteLine("Ввод некоректныйю Введите число");
        number = ReadNumber(text);
    }
    return number;
}

void WriteNumber(string text) {
Console.WriteLine(text);
}
*/
//Задача No21. Работа в группах
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//● A (3,6); B (2,1) -> 5,09
//● A (7,-5); B (1,-1) -> 7,21


/*
//Задача No22. Работа в группах
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.
//● 5 -> 1, 4, 9, 16, 25.
//● 2 -> 1,4

int num = int.Parse(Console.ReadLine());
int[] arr = GetCalculateTheSquaresOfnumbers(num);

PrintArray(arr);

int[] GetCalculateTheSquaresOfnumbers(int N);
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = (i+1) * (i+1);
    }
    return array;

}

void PrintArray(int []array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
*/





