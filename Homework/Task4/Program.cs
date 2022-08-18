Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

Test(a);
Test(b);
Test(c);

Console.WriteLine("Максимальное число это - " + max);

void Test(int count)
{
    if(count > max) max = count;
}