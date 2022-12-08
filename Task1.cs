Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10 && number < 100000 && number > 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет, число должно быть пятизначным и положительным");
}