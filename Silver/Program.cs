Console.WriteLine("Программа показывает является ли введённое число чётным");
Console.WriteLine("Введите число...");
int A = Convert.ToInt32(Console.ReadLine());

if (A == 0)
{
    Console.WriteLine("Вы ввели 0");
}
else if (A % 2 == 0)
{
    Console.WriteLine($"Число {A} является чётным.");
}
else
{
    Console.WriteLine($"Число {A} не является чётным.");
}
