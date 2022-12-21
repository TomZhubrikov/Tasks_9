// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersRec (int num, int finishSum) {
    if (num == finishSum) return num;
    else {
        return num + SumNumbersRec(num + 1, finishSum);
    }
}

Console.Clear();
Console.Write("Enter a first number -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter a second number -> ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumNumbersRec(m, n)}");

