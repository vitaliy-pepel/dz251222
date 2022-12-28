// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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
int m = InputNumber("Введите m: ");
int n = InputNumber("Введите n: ");
System.Console.Write(Ackermann(m, n));

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackermann(m - 1, 1);
    }
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

