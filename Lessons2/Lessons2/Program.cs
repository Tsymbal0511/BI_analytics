//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывет найбольшую цифру числа 78 -> 8 12 -> 2

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

