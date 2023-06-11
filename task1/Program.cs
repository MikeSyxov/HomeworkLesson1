// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите первое число: ");
string inputV = Console.ReadLine();
int n1 = Convert.ToInt32(inputV);

Console.Write("Введите второе число: ");
string inputV2 = Console.ReadLine();
int n2 = Convert.ToInt32(inputV2);

Console.WriteLine($"Вы ввели числа  {n1} и {n2}");

if (n1 > n2)
{
    Console.WriteLine($"Первое число {n1} больше чем, второе {n2}");
}
else
{
    Console.WriteLine($"Второе число {n2} больше чем, первое {n1}");
}