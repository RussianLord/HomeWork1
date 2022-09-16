Console.WriteLine("Программа показывает наибольшее число из двух введённых");
Console.WriteLine("Введите ПЕРВОЕ число...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число А = " + A);
Console.WriteLine("Введите ВТОРОЕ число...");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число В = " + B);

if(A == B)
{
Console.WriteLine($"Число A = {A} и число B = {B} равны");
}
else if(A>B)
{
    Console.WriteLine($"Число A = {A} больше числа B = {B}");
}
else
{
    Console.WriteLine($"Число B = {B} больше числа A = {A}");
}
