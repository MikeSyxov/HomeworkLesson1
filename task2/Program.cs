// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

int n1 = ReadInt("Введите первое число: ");
int n2 = ReadInt("Введите второе число: ");
int n3 = ReadInt("Введите третье число: ");
int max = n1;

if (max < n2) max = n2;
if (max < n3) max = n3;

Console.WriteLine($"Максимальное число: {max}");
