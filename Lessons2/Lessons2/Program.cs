//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывет найбольшую цифру числа 78 -> 8 12 -> 2
/*
Random random = new Random();

int randomNumber = random.Next(10,100);

int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 10 % 10;

Console.WriteLine(randomNumber);

if (lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}

//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46 782 -> 72 918 -> 98

Random random = new Random();

int number = random.Next(100,1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int lastDigit = number % 10;
int newDigit = firstDigit * 10 + lastDigit;

Console.WriteLine(newDigit);


//12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 16, 4 -> кратно


int firstNumber = ReadNumber("Введите первое число");
int secondNumber = ReadNumber("Введите второе число");
Console.WriteLine("Первое число: " + firstNumber);
Console.WriteLine("Второе число: " + secondNumber);

int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine();
    if (int.TryParse(readNumber, out number)) {}
    else {
        Console.WriteLine("Введите еще раз");
        number = ReadNumber(text);
    }
    return number;
}
if (firstNumber % secondNumber == 0) {
    Console.WriteLine("Первое число кратное второму");
} else {
    Console.WriteLine("Первое число не кратное втоому. Остаток от деленеия" + firstNumber % secondNumber);
}

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

int randomNumber1 = int.Parse(Console.ReadLine());

int result1 = randomNumber1 % 7;
int result2 = randomNumber1 % 23;

if ((result1 == 0) & (result2 == 0))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/

//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

Console.Write("Enter first num");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter socond num");
 int num2 = Convert.ToInt32(Console.ReadLine());
 if ((Math.Pow(num1, 2) == num2) | (Math.Pow(num2, 2) == num1))
{
    Console.WriteLine("One numder is the squeare of the second");
}
else
{
    Console.WriteLine("One numder is not the squeare of the second");
}


