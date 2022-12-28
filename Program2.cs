// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
int m = InputNumber("Введите левую границу m: ");
int n = InputNumber("Введите правую границу n: ");
System.Console.Write(Number_Series(m, n, -1));

int Number_Series(int m, int n, int ct)
{   
    if ((m + ct) == n)
    {
        return 0;
    }
    ct += 1;
    int summ = (m + ct) + Number_Series(m , n, ct);
    return summ;
}

