// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

int n1 = ReadInt("Введите число: ");
int rem = Rem(n1);
System.Console.WriteLine($"Вы ввели число {n1} ");

int Rem(int n1)
{
    int rem = n1 % 2;
    if (rem == 0)
    {
        return rem;
    }
    rem = 2 % n1;
    return rem;
}

if (rem == 0)
{
    System.Console.WriteLine($"Число {n1} чётное");
}
else
{
    System.Console.WriteLine($"Число {n1} не чётное ");
}