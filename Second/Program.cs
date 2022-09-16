Console.WriteLine("Введите ПЕРВОЕ число...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число А = " + A);
Console.WriteLine("Введите ВТОРОЕ число...");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число В = " + B);
Console.WriteLine("Введите ТРЕТЬЕ число...");
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число С = " + C);

if(A == B & A == C)
{
    Console.WriteLine("Вы ввели одинаковые числа");
}
else if(A == B & A > C)
{
    Console.WriteLine($"Число A = {A} и число B = {B} самые большые числа из списка");
}
else if(A == C & A > B)
{
    Console.WriteLine($"Число A = {A} и число C = {C} самые большые числа из списка");
}
else if(B == C & B > A)
{
    Console.WriteLine($"Число B = {B} и число C = {C} самые большые числа из списка");
}    
else if(A > B & A > C)
{
    Console.WriteLine($"Число {A} самое большое число из списка");
}
else if(C > B & C > A)
{
    Console.WriteLine($"Число {C} самое большое число из списка");
}
else
{
    Console.WriteLine($"Число {B} самое большое число из списка");
}