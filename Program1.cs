// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumber(string str)
{
int number;
string text;
    while (true)
    {
    Console.Write(str);
    text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        break;
    }
    Console.WriteLine("Введено не число, попробуйте еще раз.");
    }
    return number;
}

Console.Clear();
int n = InputNumber("Введите левую границу n: ");
Number_Series(n);

void Number_Series(int n)
{
    if (n == 0)
    {
        return;
    }
    System.Console.Write($"{n} ");
    Number_Series(n - 1);
}

