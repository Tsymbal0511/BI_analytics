//Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36

/*int a = int.Parse(Console.ReadLine());
int sum = GetSumNumbersBetweenOneToNumber(a);
Console.WriteLine(sum);
int GetSumNumbersBetweenOneToNumber(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int[] numbers = new int[]{12,3,23};
PrintArray(numbers);
void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

Math.Pow(234,2);

int Pow(){
    
}

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3 78 -> 2 89126 -> 5

int number = int.Parse(Console.ReadLine());
int result = GetLengthNumber(number);
Console.WriteLine(result);

int GetLengthNumber(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number/10;
        count ++;
    }
    return count;
}

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4->24 5->120

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
double multi = GetMultiNumbersBetweenOneToNumber(a);
Console.WriteLine(multi);

double GetMultiNumbersBetweenOneToNumber(int a)
{
    double multi = 1;
    for (var i =1; i <= a; i++)
    {
        multi = multi * i;
    }
    return multi;

}

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] result = CreateArray();
PrintArray(result);

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}
*/


