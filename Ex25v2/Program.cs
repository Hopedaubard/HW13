// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Main();

void Main()
{
    int numA = Prompt("Введите число: ");
    int numB = Prompt("Введите показатель степени числа: ");
    double numC = DoExp(numA, numB);
    Console.WriteLine($"Число {numA} в натуральной степени {numB} равняется {numC}");
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

double DoExp(int num, int exp)
{
    if (exp == 0)
    {
        return 1;
    }
    if (exp < 0)
    {
        double numDouble = Convert.ToDouble(num);
        numDouble = 1 / numDouble;
        Console.WriteLine(numDouble);
        double res1 = numDouble;
        for (int i = -2; i >= exp; i--)
        {
            res1 *= numDouble;
        }
        return Math.Round(res1, 3);
    }
    double res2 = num;
    for (int j = 2; j <= exp; j++)
    {
        res2 *= num;
    }
    return res2;
}
