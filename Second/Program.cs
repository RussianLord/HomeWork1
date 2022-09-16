Console.WriteLine("Введите ПЕРВОЕ число...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первое число = " + A);
Console.WriteLine("Введите ВТОРОЕ число...");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число = " + B);
Console.WriteLine("Введите ТРЕТЬЕ число...");
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число = " + C);

if(A>B & A>C)
{
    Console.WriteLine($"Число {A} самое большое число из списка");
}
else if(C>B & C>A)
{
    Console.WriteLine($"Число {C} самое большое число из списка");
}
else
{
    Console.WriteLine($"Число {B} самое большое число из списка");
}