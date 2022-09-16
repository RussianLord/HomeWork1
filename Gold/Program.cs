Console.WriteLine("Введите число...");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (N == 0)
{
Console.WriteLine("Вы ввели 0");
}
else
{
while(count <= N)
    
{
    if (count % 2 == 0)
{
    Console.Write(count + ",");
}
    count++;
}
Console.WriteLine("Были выведены все чётные числа");
}