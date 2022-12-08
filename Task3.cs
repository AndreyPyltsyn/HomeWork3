Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

for (int N = 1; N < number; N++)
{
    Console.Write(Math.Pow(N, 3) + ", ");
}
Console.Write(Math.Pow(number, 3));