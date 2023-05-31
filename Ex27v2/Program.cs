// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Main();

void Main()
{
    int num = Prompt("Введите число: ");
    SumDigitInNum(num);
}


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void SumDigitInNum(int userNum)
{
    userNum = Math.Abs(userNum);
    bool checkValid = true;
    if (userNum == 0)
    {
        checkValid = false;
    }
    if (checkValid == true)
    {
        int temp = userNum;
        int count = 0;
        for (int i = 1; userNum > 0; i++)
        {
            userNum /= 10;
            count = i;
        }
        // Console.WriteLine(count);
        int result = 0;
        userNum = temp;
        for (int j = 0; j <= count; j++)
        {
            result += userNum % 10;
            userNum /= 10;
        }
        Console.WriteLine($"Сумма цифер в числе {temp} равна: {result}");
    }
    if (checkValid == false)
    {
        Console.WriteLine("Сумма цифер в числе 0: 0");
    }
}