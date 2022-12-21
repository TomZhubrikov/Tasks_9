// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int RecFunction (int num1, int num2) {
    if (num1 == 0) return num2 + 1;
    else if (num1 > 0 && num2 == 0) return RecFunction (num1 - 1, 1);
    else if (num1 > 0 && num2 > 0) return RecFunction (num1 - 1, RecFunction (num1, num2 - 1));
    else return -1;
}

Console.Clear();
int m, n;
while (true)
{
    Console.Write("Enter a first number (m >= 0) -> ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Enter a second number (n >= 0) -> ");
    n = int.Parse(Console.ReadLine());
    if (m >= 0 && n >= 0) break;
}

Console.WriteLine($"A(m,n) = {RecFunction(m, n)}");


