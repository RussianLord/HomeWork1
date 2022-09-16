Console.WriteLine("Ввидете число...");
int A = Convert.ToInt32(Console.ReadLine());
int B = A % 2;

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