Console.WriteLine("Введите ПЕРВОЕ число...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первое число = " + A);
Console.WriteLine("Введите ВТОРОЕ число...");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число = " + B);

if(A>B)
{
    Console.WriteLine($"Число {A} больше числа {B}");
}
else
{
    Console.WriteLine($"Число {B} больше числа {A}");
}
