// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

/*
int[] array = CreateRandomArray(12, -9, 9);
PrintArray(array);



int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    string str = string.Join(",", array);
    Console.WriteLine($"[ {str} ]");

    //Console.WriteLine(string.Join(",", array));
}

*/
/*int[] sumNegativeAndPositive = GetSumPositiveAndSumNagativeNumbers(array);
PrintArray(sumNegativeAndPositive, "Sum Positive and Negative");
int[] GetSumPositiveAndSumNagativeNumbers(int[] array)
{
    int[] sumNegativeAndPositive = new int[2];
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumNegativeAndPositive[0] += array[i];
        }
        else
        {
            sumNegativeAndPositive[1] += array[i];
        }
    }
    return sumNegativeAndPositive;
}
*/

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
/*
int[] array = new int[] { 1, -2, 3, -4, 5, -6, 7, -8 };

Console.WriteLine(string.Join(",", ChangeArray(array)));

int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            array[i] = array[i] * -1;
        }
    }
    return array;
}


//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine(SearchNumberInArray(12, array));
Console.WriteLine(SearchNumberInArray(1, array));

int[] ChangeArray(int[] array)
{
    int[] new Array = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        new Array[i] = array[i] * -1;
    }
    return new Array;
}

int SearchNumberInArray(int[] array, int[] numbers)
{
    int count = 0;

    for (int i = 0; i = array.Length; i++)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            if (array[i] == numbers[j])
            {
                count++;
            }
        }
    }
    return count;
}



//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] array = CreateRandomArray(123, -200, 200);
PrintArray(array);
Console.WriteLine("Введите диапазон поиска");
int startNum = EnterNumber("Начало:");
int endNum = EnterNumber("Конец:");
Console.WriteLine($"найдено: {CountNumbersInArray(array, startNum, endNum)}");


int CountNumbersInArray(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end){
            count++;
        }
    }
    return count;
}

*/
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21







